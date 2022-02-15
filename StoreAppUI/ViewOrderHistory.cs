using OrderModel;
using ProductModel;
using StoreBL;
using StoreFrontModel;

namespace StoreUI
{
    public class ViewOrderHistory : IMenu
    {
        public void Display()
        {
            Console.WriteLine("==View Order History==");
            Console.WriteLine("[2] View Store Order History");
            Console.WriteLine("[1] View Customer Order History");
            Console.WriteLine("[0] Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "2":

                break;
                case "1":
                break;
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