using StoreAppDL;
using CustomerModel;

namespace StoreBL
{
    public class StoreFrontBL : IStoreFrontBL
    {
        //Dependency Injection Pattern
        //- This is the main reason why we created interface first before the class
        //- This will save you time on re-writing code that breaks if you updated a completely seperate class
        //- Main reason is to prevent us from re-writing code that already existed on (potentially) 50 file or more without
        //the compiler helping us
        //===========================
        private IRepository _repo;
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //===========================

        public Customer AddCustomer(Customer c_customer)
        {
            Random rand = new Random();

        //     //Processing data to meet conditions
        //     //Not sure if this step is needed for adding customers

        //     //Validation Process
            
        }
    }
}
