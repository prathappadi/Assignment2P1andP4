using Assigment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        public static List<Device> DeviceDetails = new List<Device>
        {
            new Device(1,100,"Lenovo",97,6,64,68),
            new Device(1,102,"Redmi",98,7,128,132),
            new Device(2,1001,"Samsung",100,12,64,256)
        };


        /// <summary>
        /// Get all the device.
        /// </summary>
        [HttpGet]
        public ActionResult AllDeviceDetails()
        {
            return Ok(DeviceDetails);
        }

        [HttpGet("{customerID}")]
        public async Task<ActionResult> GetDevicebyCustomerID(int customerID)

        {
            var deviceData = DeviceDetails.FindAll(h => h.customerID == customerID);
            return deviceData == null ? NotFound() : Ok(deviceData);

            // Ok(deviceData);
        }

        [HttpPost]
        public ActionResult AddCustomer(Device dev)
        {
            DeviceDetails.Add(dev);
            return Ok(" Device Added Succefully");
        }





    }
}
