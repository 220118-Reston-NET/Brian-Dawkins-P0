using System.Data.SqlClient;
using CustomerModel;

namespace StoreAppDL
{
    public class SQLRepository : IRepository
    {
        //SQLRepository now requires you to provide a connectionString to an existing database to create an object out of it
        //It will also allow SQLRepository to dynamically point to different databases as long as you have the connection string for it 
        private readonly string _connectionStrings;
        public SQLRepository (string p_connectionStrings)
        {
            _connectionStrings = p_connectionStrings;
        }
        public Customer AddCustomer(Customer c_customer)
        {
            //@before the string will ignore the special characters like \n
            //This is where you specify the sql statement required to whatever operation you need based on the method
            //
            string sqlQuery = @"insert into customer 
                                values(@Name, @_address)";

            //using block is different from our normal using statement
            //It is used to automatically close any resource you stated inside of the parenthesis
            //If an exception occurs it will still automatically close any resources
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                //Opens the connection to the database
                con.Open();

                //SqlCommand class is a class specialized in executing SQL statements
                //Command will hold the sqlQuery that wil execute on the current connection that we have in the con object
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@Name", c_customer.Name);
                command.Parameters.AddWithValue("@_address", c_customer.Address);

                //Executes the SQL statement
                command.ExecuteNonQuery();
            }

            return c_customer;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listOfCustomers = new List<Customer>();

            string sqlQuery = @"select * from customer";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                //Opens connection to the database
                con.Open();

                //Create command object that has our sqlQuery and con object
                SqlCommand command = new SqlCommand(sqlQuery, con);

                //SqlDataReader is a class specialized in reading outputs that came from a sql statement
                //Usually this outputs are in a form of a table and keep that in mind 
                SqlDataReader reader = command.ExecuteReader();

                //Read() method checks if you have more rows to go through
                //If there is another row = true, if not = false
                while (reader.Read())
                {
                    //Zero based column index
                    listOfCustomers.Add(new Customer(){
                        CustomerId = reader.GetInt32(0), //It will get the column customerId since that is the very first column of our select statement
                        Name = reader.GetString(1), //It will get the name of the Name column since it is the second column of our select statement
                        Address = reader.GetString(2) //It will get the address of the Address column since it is the third column of our select statement
                    });
                }
            }

            return listOfCustomers;
        }
    }
}