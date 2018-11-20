using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deviceemulator
{
    public class EnzoIotHubOperations
    {
        private EnzoHttpAzureIoTHub _enzo = null;

        public EnzoIotHubOperations(EnzoHttpAzureIoTHub enzo) { _enzo = enzo; }
        
        public List<dynamic> ListDevices(int maxCount = 100, string deviceidStartsWith = null)
        {
            string count = "count: " + maxCount;
            if (deviceidStartsWith != null)
                deviceidStartsWith = "id:" + deviceidStartsWith;
            return _enzo.ExecuteAsDynamic("listdevices", deviceidStartsWith, count);
        }

        public List<dynamic> SendData(string deviceId, string data, string properties = null, string messageId = null, string correlationId = null)
        {
            deviceId = "id:" + deviceId;
            data = "data:" + data;
            if (properties != null)
                properties = "properties:" + properties;
            if (messageId != null)
                messageId = "messageId:" + messageId;
            if (correlationId != null)
                correlationId = "correlationId:" + correlationId;
            return _enzo.ExecuteAsDynamic("SendData", deviceId, data, properties, messageId, correlationId);
        }

        public List<dynamic> SendTestData(string deviceId, string data, string properties = null, string messageId = null)
        {
            string msgCount = "msgCount:1";
            string delayms = "delayms:1";
            deviceId = "id:" + deviceId;
            data = "data:" + data;
            if (properties != null)
                properties = "properties:" + properties;
            if (messageId != null)
                messageId = "messageId:" + messageId;
            return _enzo.ExecuteAsDynamic("SendTestData", delayms, msgCount, deviceId, data, properties, messageId);
        }

        public List<dynamic> CreateDevice(string deviceId = null, string primaryKey = null, string secondaryKey = null)
        {
            if (deviceId != null)
                deviceId = "id:" + deviceId;
            if (primaryKey != null)
                primaryKey = "primaryKey:" + primaryKey;
            if (secondaryKey != null)
                secondaryKey = "secondaryKey:" + secondaryKey;
            return _enzo.ExecuteAsDynamic("createdevice", deviceId, primaryKey, secondaryKey);
        }

        public List<dynamic> CreateDevices(string deviceId, string range)
        {
            deviceId = "id:" + deviceId;
            range = "$range$:" + range; // range is a reserved HTTP header; surrounding with $ to send to Enzo
            return _enzo.ExecuteAsDynamic("createdevices", deviceId, range);
        }

        public List<dynamic> DeleteDevice(string deviceId)
        {
            deviceId = "id:" + deviceId;
            return _enzo.ExecuteAsDynamic("deletedevice", deviceId);
        }

        public List<dynamic> DeleteDevices(string deviceId, string range)
        {
            deviceId = "id:" + deviceId;
            range = "range:" + range;
            return _enzo.ExecuteAsDynamic("deletedevices", deviceId, range);
        }
        public void FlushDeviceCache()
        {
            _enzo.ExecuteAsDynamic("FlushDeviceCache");
        }
        
        public List<dynamic> UpdateDevice(string deviceId, string primaryKey = null, string secondaryKey = null)
        {
            deviceId = "id:" + deviceId;
            if (primaryKey != null)
                primaryKey = "primaryKey:" + primaryKey;
            if (secondaryKey != null)
                secondaryKey = "secondaryKey:" + secondaryKey;
            return _enzo.ExecuteAsDynamic("updatedevice", deviceId, primaryKey, secondaryKey);
        }
    }
}
