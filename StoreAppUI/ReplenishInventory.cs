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
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[0] Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                case "0":
                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Main Menu";
                }

            }
        }
    }