using CustomerModel;

namespace StoreAppDL
{
    public class SQLRepository : IRepository
    {
        public Customer AddCustomer(Customer c_customer)
        {
            string sqlQuery = @"insert into customer 
                                values ({c_customer.})";
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
}