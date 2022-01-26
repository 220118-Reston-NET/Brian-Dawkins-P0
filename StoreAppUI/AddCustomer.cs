using StoreBL;
using CustomerModel;

namespace StoreUI
{
    public class AddCustomer : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddCustomer
        private static Customer _newCustomer = new Customer();

        //Dependency Injection
        //=========================
        private IStoreFrontBL _customerBL;
        public AddCustomer(IStoreFrontBL c_customerBL)
        {
            _customerBL = c_customerBL;
        } 
        //================================

        public void Display()
        {
            Console.WriteLine("Enter Customer Information");
            Console.WriteLine("[3] Name - " + _newCustomer.Name);
            Console.WriteLine("[2] Address - " + _newCustomer.Address);
            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    //Exception handling to have better user experience 
                    try
                    {
                        _customerBL.AddCustomer(_newCustomer);
                    } 
                    catch (System.Exception exc)
            }
        }
    }
}
