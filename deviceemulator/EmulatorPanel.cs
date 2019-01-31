using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deviceemulator
{
    public partial class EmulatorPanel : UserControl
    {
        private bool _running = false;
        private Emulator _emulator = null;

        public EmulatorPanel(Emulator emulator)
        {
            InitializeComponent();
            _emulator = emulator;

            if (_emulator.Devices == null)
                _emulator.Devices = new List<string>();

            RefreshPanel();

            _emulator.OnEmulatorCompleted += _emulator_OnEmulatorCompleted;
            _emulator.OnEmulatorMessage += _emulator_OnEmulatorMessage;
        }

        private void RefreshPanel()
        {
            listBoxDevices.Items.Clear();
            foreach (string device in _emulator.Devices) listBoxDevices.Items.Add(device);
            textBoxPayload.Text = _emulator.Payload;
            numericUpDownDelay.Value = _emulator.Delay;
            numericUpDownMaxThreads.Value = _emulator.MaxThreads;
            numericUpDownTotalCount.Value = _emulator.TotalCount;
            textBoxResult.Text = "";
        }

        private void _emulator_OnEmulatorMessage(string message)
        {
            textBoxResult.Invoke((MethodInvoker)delegate
            {
                textBoxResult.Text = DateTime.UtcNow.ToString() + ": " + message + Environment.NewLine + textBoxResult.Text;
            });
        }

        private void _emulator_OnEmulatorCompleted()
        {
            buttonStartStop.Invoke((MethodInvoker)delegate
            {
                buttonStartStop.Text = "START";
                buttonStartStop.BackColor = Color.Gold;
            });

            textBoxResult.Invoke((MethodInvoker)delegate
            {
                textBoxResult.Text = DateTime.UtcNow.ToString() + ": " + "Emulation completed" + Environment.NewLine + textBoxResult.Text;
            });

            _running = false;

            SetUI(true);
            
        }

        private void linkLabelUnassign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelAssign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        
        public Emulator Emulator { get { return _emulator; } }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                buttonStartStop.Enabled = false;
                if (_running)
                {
                    _emulator.Stop();

                    while (_emulator.IsRunning)
                    {
                        System.Threading.Thread.Sleep(100);
                    }

                    buttonStartStop.Text = "START";
                    buttonStartStop.BackColor = Color.Gold;
                    _running = false;

                    SetUI(true);

                }
                else
                {
                    if (ValidateInput())
                    {
                        _emulator.Delay = Convert.ToInt32(numericUpDownDelay.Value);
                        _emulator.TotalCount = Convert.ToInt32(numericUpDownTotalCount.Value);
                        _emulator.Payload = textBoxPayload.Text;
                        _emulator.Devices = new List<string>();
                        _emulator.MaxThreads = Convert.ToInt32(numericUpDownMaxThreads.Value);
                        foreach (string item in listBoxDevices.Items) _emulator.Devices.Add(item);

                        textBoxResult.Text = "";
                        tabControlData.SelectTab(1);

                        _emulator.Start();

                        SetUI(false);

                        buttonStartStop.Text = "STOP";
                        buttonStartStop.BackColor = Color.OrangeRed;
                        
                        _running = true;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
            buttonStartStop.Enabled = true;
        }

        public bool CanStart { get { return ValidateInput(false) && !_emulator.IsRunning; } }
        public bool CanStop { get { return _emulator.IsRunning; } }

        public void Start() { if (CanStart) buttonStartStop_Click(null, null); }
        public void Stop() { if (CanStop) buttonStartStop_Click(null, null); }

        public void ClearDevices()
        {
            listBoxDevices.Items.Clear();
            _emulator.Devices.Clear();
        }

        public void RemoveSelectedDevices()
        {
            var selected = listBoxDevices.SelectedItems;
            for (int i = selected.Count; i > 0; i--)
            {
                listBoxDevices.Items.Remove(selected[i - 1]);
            }
            _emulator.Devices.Clear();
            foreach (string device in listBoxDevices.Items) { _emulator.Devices.Add(device); }
        }

        public int SelectedDevicesCount { get { return listBoxDevices.SelectedItems.Count; } }

        public void AddDevice(string deviceId)
        {
            listBoxDevices.Items.Add(deviceId);
            _emulator.Devices.Add(deviceId);
        }

        private bool ValidateInput(bool showMessage = true)
        {

            if (textBoxPayload.Text.Trim().Length == 0)
            {
                if (showMessage)
                    MessageBox.Show(this, "Please enter a payload to emulate", "Error");
                return false;
            }
            if (listBoxDevices.Items.Count == 0)
            {
                if (showMessage)
                    MessageBox.Show(this, "Please select devices to emulate", "Error");
                return false;
            }
            return true;
        }

        private void SetUI(bool enable)
        {
            this.Invoke((MethodInvoker)delegate
            {
                numericUpDownTotalCount.Enabled = enable;
                numericUpDownDelay.Enabled = enable;
                panelPayload.Enabled = enable;
                panelDevices.Enabled = enable;
            });
        }

        private void linkLabelPayloadHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ui.help help = new ui.help(deviceemulator.Properties.Resources.payload_help);
                help.Show();
            }
            catch { }
        }

        private void textBoxPayload_TextChanged(object sender, EventArgs e)
        {
            _emulator.Payload = textBoxPayload.Text;
        }

        private void numericUpDownMaxThreads_ValueChanged(object sender, EventArgs e)
        {
            _emulator.MaxThreads = Convert.ToInt32(numericUpDownMaxThreads.Value);
        }

        private void numericUpDownTotalCount_ValueChanged(object sender, EventArgs e)
        {
            _emulator.TotalCount = Convert.ToInt32(numericUpDownTotalCount.Value);
        }

        private void numericUpDownDelay_ValueChanged(object sender, EventArgs e)
        {
            _emulator.Delay = Convert.ToInt32(numericUpDownDelay.Value);
        }
    }
}
