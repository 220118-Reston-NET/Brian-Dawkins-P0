// using CustomerModel;
// using OrderModel;
// using ProductModel;
// using StoreBL;
// using StoreFrontModel;

// namespace StoreUI
// {
//     public class PlaceOrder : IMenu
//     {
//         private static Customer customerid = new Customer();
//         private static Orders _newOrder = new Orders();
//         private static StoreFront _newFront = new StoreFront();
        

//         private IStoreFrontBL _StoreFrontBL;
//         private List<Customer> listOfCustomers;
//         public PlaceOrder(IStoreFrontBL c_customerId)
//         {
//             _StoreFrontBL = c_customerId;
//             listOfCustomers = _StoreFrontBL.GetAllCustomers();
//         }

//         public static Customer selectedCustomer = new Customer(); 
//         public void Display()
//         {
//             Console.WriteLine("==Welcome to the ordering menu!===");
//             Console.WriteLine("Would you like to place an order?");
//             Console.WriteLine("[1] Yes ");
//             Console.WriteLine("[0] Go Back");
//         }

//         public string UserChoice()
//         {
//             string userInput = Console.ReadLine();
//             //Setting up outline for Menu, need to add functionality to it and make it work
//             switch (userInput)
//             {
//                 case "1":
//                 break;
//                 case "0":
//                     return "MainMenu";
//                 default:
//                     Console.WriteLine("Please input a valid response");
//                     Console.WriteLine("Please press Enter to continue");
//                     Console.ReadLine();
//                     return "PlaceOrder";
//             }
//         }
//     }