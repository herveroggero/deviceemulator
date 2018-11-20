using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace deviceemulator
{
    /// <summary>
    /// Class that holds a list of devices to emulate along with the emulation logic.
    /// The EmulateDevices method is started asynchronously using the Start() method.
    /// </summary>
    public class Emulator : BaseEmulator
    {
        private Thread _thread = null;
        private CancellationTokenSource cts = new CancellationTokenSource();
        private EnzoHttpAzureIoTHub _enzo = null;

        internal delegate void OnEmulatorCompletedDelegate();
        internal event OnEmulatorCompletedDelegate OnEmulatorCompleted;
        internal delegate void OnEmulatorMessageDelegate(string message);
        internal event OnEmulatorMessageDelegate OnEmulatorMessage;

        public Emulator() { EmulatorId = Guid.NewGuid(); }

        public Emulator(EnzoHttpAzureIoTHub enzo, string payload, int totalCount = 100, int delay = 1000)
        {
            _enzo = enzo;
            Payload = payload;
            TotalCount = totalCount;
            Delay = delay;
            MaxThreads = 4;
            EmulatorId = Guid.NewGuid();
        }

        public Guid EmulatorId { get; set; }

        public bool IsRunning { get { return (_thread == null) ? false : _thread.IsAlive; } }

        public int MaxThreads { get; set; }

        public string Payload { get; set; }
        public int Delay { get; set;}
        public int TotalCount { get; set; }

        public void Start()
        {
            if (_enzo == null)
                throw new InvalidProgramException("The Enzo settings have not been provided; cannot start the emulator.");

            if (_thread == null || _thread.ThreadState == ThreadState.Stopped)
            {
                _thread = new Thread(new ParameterizedThreadStart(EmulateDevices));
            }

            cts = new CancellationTokenSource();

            _thread.Start(cts.Token);

        }

        private void PostMessage(string message)
        {
            if (OnEmulatorMessage != null)
                OnEmulatorMessage.BeginInvoke(message, null, null);
        }

        internal void EmulateDevices(object obj)
        {
            try
            {
                EnzoIotHubOperations op = new EnzoIotHubOperations(_enzo);

                CancellationToken ct = (CancellationToken)obj;

                Action<string> sendData = null;

                #region Code that sends the payload to Enzo
                sendData = (deviceId) => {
                    
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Start();

                    try
                    {
                        var res = op.SendTestData(deviceId, Payload);
                        PostMessage("Data sent to device id '" + deviceId + "' in " + res[0].durationms.ToString() + " ms: " + res[0].data);
                    }
                    catch (Exception ex)
                    {
                        PostMessage("Data send error (" + deviceId + "): " + ex.Message);
                    }
                    sw.Stop();
                    
                };
                #endregion

                int totalCount = 0;

                ParallelOptions po = new ParallelOptions();
                if (MaxThreads == 0)
                    MaxThreads = System.Environment.ProcessorCount * 4;

                po.MaxDegreeOfParallelism = MaxThreads;

                PostMessage("Starting emulation with up to " + po.MaxDegreeOfParallelism.ToString() + " threads");

                do
                {
                    Parallel.ForEach(Devices, po, (devId, loopstate) =>
                    {

                        if (ct.IsCancellationRequested)
                        {
                            //loopstate.Stop();
                            return;
                        }

                        sendData(devId.Trim());
                        Interlocked.Increment(ref totalCount);
                        
                    });

                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }

                    if (Delay > 0)
                        System.Threading.Thread.Sleep(Delay);

                } while (totalCount < TotalCount);

                System.Diagnostics.Debug.WriteLine("Thread exiting...");

                if (ct.IsCancellationRequested)
                    PostMessage("Cancellation completed");

            }
            catch (Exception ex)
            {
                // Exception captured... continue until cancelled.
                PostMessage("ERROR: " + ex.Message);
            }

            if (OnEmulatorCompleted != null)
                OnEmulatorCompleted.BeginInvoke(null, null);

            
        }

        public void Stop()
        {
            cts.Cancel();
        }

        /// <summary>
        /// Return a serialized version of this object
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            string res = "";

            System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(Emulator));
            MemoryStream stream = new MemoryStream();
            s.Serialize(stream, this);
            byte[] data = stream.ToArray();
            res = System.Convert.ToBase64String(data);
            return res;
        }

        /// <summary>
        /// Deserialize a previously serialized object
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Emulator Deserialize(string data)
        {
            byte[] bytes = System.Convert.FromBase64String(data);
            System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(Emulator));
            MemoryStream stream = new MemoryStream(bytes);
            Emulator obj = (Emulator)s.Deserialize(stream);
            return obj;
        }

    }

    public static class EmulatorWorkspaceExtensions
    {
        public static string Serialize(this List<Emulator> list)
        {
            string res = "";
            foreach(var e in list)
            {
                res += e.Serialize() + "|";
            }
            return res;
        }

        public static List<Emulator> Load(this List<Emulator> list, string data)
        {
            List<Emulator> newList = new List<Emulator>();

            string[] emulators = data.Split('|');
            foreach(string emulator in emulators)
            {
                if (!string.IsNullOrEmpty(emulator))
                {
                    var obj = Emulator.Deserialize(emulator);
                    newList.Add(obj);
                }
            }

            return newList;
        }

    }

}
