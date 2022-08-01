using Assigment.Models;
using MongoDB.Driver;

namespace Assigment.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMongoCollection<Customer> _Customers;

        public CustomerService(ISureMDMDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);

            _Customers = database.GetCollection<Customer>(settings.CollectionName);
        }

        public List<Customer> Get()
        {
            return _Customers.Find(customer => true).ToList();
        }

        public Customer Get(string id)
        {
            throw new NotImplementedException();
            //return _Customers.Find(customer => Customer.customerId == id).FirstOrDefault();



        }

        public Customer Create(Customer customer)
        {
            _Customers.InsertOne(customer);
            return customer;
        }

        public void Update(string id, Customer Cus)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
