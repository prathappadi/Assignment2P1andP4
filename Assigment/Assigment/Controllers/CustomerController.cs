using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using Assigment.Models;

namespace Assigment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {


        public static List<Customer> cusData = new List<Customer>
        {
            new Customer(1, "abcd", "prathap@gmail.com", "42Gears"),
            new Customer(2,"Shubham","Shubham@gmail.com","42Gears")

        };



        //show all The Customer
        [HttpGet]
        public ActionResult GetAllCustomer()
        {
            return Ok(cusData);
            //return 
        }

        //get all the Customer with Id
        [HttpGet("{id}")]
        public ActionResult GetCustomerById(int id)
        {
            var Customerdata = cusData.Find(h => h.customerId == id);
            if (Customerdata == null)
            {
                return BadRequest("Customer not found or doesnot Exists");
            }
            else
            {
                return Ok(Customerdata);
            }
        }

        //get all customer IDs
        //[HttpGet]
        //public async Task<ActionResult<List<int>>> getAllCustomerId()
        //{
        //    //int[] customerIdAll = new int[cusData.Count];

        //    return cusData.Select(t => t.customerId).ToList();
        //}

        //add Customer
        [HttpPost]
        public ActionResult AddCustomer(Customer CusObj)
        {
            cusData.Add(CusObj);
            return Ok("Added Succefully");
        }

        //Delete Customer
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)

        {
            var deleteUser = cusData.Find(h => h.customerId == id);

            if (deleteUser == null)
            {
                return BadRequest("Customer DoesNot Exist");
            }
            return Ok("Deleted Customer");
        }

    }
}
