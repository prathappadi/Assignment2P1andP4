using Assigment.Models;

namespace Assigment.Services
{
    public interface ICustomerService
    {

        
            List<Customer> Get();
            Customer Get(string id);
            Customer Create(Customer student);
            void Update(string id, Customer student);
            void Remove(string id);
       
    }
}
