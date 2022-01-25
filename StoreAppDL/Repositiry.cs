using System.Text.Json;
using CustomerModel;

namespace StoreAppDL
{
    public class Repository : IRepository
    {
        //Relative filepath is from the StoreAppUI since that is the starting point of our application
        private string _filepath = "../StoreAppDL/Database";
        private string _jsonString;
        public Customer AddCustomer(Customer c_customer)
        {
            //So we can change which JSON files we can pick on other methods
            string path = _filepath + "Customer.json";

            _jsonString = JsonSerializer.Serialize(c_customer, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path , _jsonString);

            return c_customer;
        }  
    }
}