using OrderModel;
using ProductModel;
using StoreBL;
using StoreFrontModel;

namespace StoreUI
{
    public class ReplenishInventory : IMenu
    {
        private List<StoreFront> _listOfStore = new List<StoreFront>();

        private IStoreFrontBL _storeBL;

        public ReplenishInventory(IStoreFrontBL c_storeBL)
        {
             _storeBL = c_storeBL;
             //_listOfStore = _storeBL.ViewInventory();
        }

        public void Display()
        {
            Console.WriteLine("Replenish Inventory Menu");
            Console.WriteLine("Would you like to replinish a stores Inventory?");
            Console.WriteLine("[2] Yes");
            Console.WriteLine("[1] Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "2":
                    Console.WriteLine("Which location would you like to replinish? (Store ID)");
                    int storeId = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        List<StoreFront> listOfStores = IStoreFrontBL.ViewInventory(int c_storeId);
                        Console.WriteLine("Here is the store inventory");
                        List<Products> products =  IStoreFrontBL.ViewProductsByStoreId(int c_storeId);
                        foreach(var item in products)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Enter the Id for the item you want to replinish");
                        int ProductId = Convert.ToInt32(Console.ReadLine);
                        IStoreFrontBL.ReplenishInventory(int c_productId);
                        }
                        catch(System.Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Press any key to continue:");
                            Console.ReadLine();
                        }
                    }

            }
        }
    }