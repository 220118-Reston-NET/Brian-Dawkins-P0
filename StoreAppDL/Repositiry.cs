using System.Text.Json;
using CustomerModel;
using OrderModel;
using StoreFrontModel;

namespace StoreAppDL
{
    public class Repository : IRepository
    {
        //Relative filepath is from the StoreAppUI since that is the starting point of our application
        private string _filepath = "../StoreAppDL/Database/";
        private string _jsonString;
        public Customer AddCustomer(Customer c_customer)
        {
            //So we can change which JSON files we can pick on other methods
            string path = _filepath + "Customer.json";

            _jsonString = JsonSerializer.Serialize(c_customer, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path , _jsonString);

            return c_customer;
        }  

        public List<Customer> GetAllCustomers()
        {
            //Grab information from the JSON file and store it in a string
            _jsonString = File.ReadAllText(_filepath + "Customer.json");

            //Deserialize the jsonString into a List<Pokemon> object and return it
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public List<StoreFront> GetAllStores(int c_storeId)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetOrdersByCustomerId(int c_customerId)
        {
            throw new NotImplementedException();
        }

        public List<StoreFront> ViewInventory(int c_storeId)
        {
            throw new NotImplementedException();
        }
    }
}