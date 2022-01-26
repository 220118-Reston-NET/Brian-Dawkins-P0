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
            
        }
    }
}
