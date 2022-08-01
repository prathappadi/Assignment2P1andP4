namespace Assigment.Models
{
    public class Device
    {
        public int customerID { get; set; }

        public int deviceID { get; set; }
        public string deviceName { get; set; }

        public int deviceBatteryPercentage { get; set; }

        public int deviceNetwork { get; set; }

        public int devicePhysicalStorage { get; set; }

        public int totalStorage { get; set; }

        public Device()
        {

        }

        public Device(int customerID, int deviceID, string deviceName, int deviceBatteryPercentage, int deviceNetwork, int devicePhysicalStorage, int totalStorage)
        {
            this.customerID = customerID;
            this.deviceID = deviceID;
            this.deviceName = deviceName;
            this.deviceBatteryPercentage = deviceBatteryPercentage;
            this.deviceNetwork = deviceNetwork;
            this.devicePhysicalStorage = devicePhysicalStorage;
            this.totalStorage = totalStorage;
        }


    }
}
