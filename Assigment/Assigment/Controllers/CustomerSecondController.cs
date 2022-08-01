using Assigment.Models;
using Assigment.Services;
using Microsoft.AspNetCore.Mvc;


namespace Assigment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSecondController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerSecondController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        // GET: api/<CustomerSecondController>
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            return customerService.Get();
        }

        // GET api/<CustomerSecondController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerSecondController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerSecondController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerSecondController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
