// See https://aka.ms/new-console-template for more information
//using CustomerModel;
global using Serilog;
using StoreBL;
using StoreAppDL;
using StoreUI;

//Console.WriteLine("Hello, World!");

//Creating and configuring our logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt") //We configure our logger to save in this file 
    .CreateLogger();

bool repeat = true;
IMenu menu = new MainMenu();

while(repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchCustomer":
        Log.Information("Displaying SearchCustomer Menu to user");
            menu = new SearchCustomer(new StoreFrontBL(new SQLRepository()));
            break;
        case "AddCustomer":
        Log.Information("Displaying AddCustomer Menu to user");
            menu = new AddCustomer(new StoreFrontBL(new SQLRepository()));
            break;
        case "MainMenu":
            Log.Information("Displaying MainMenu to user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Information("Exiting application");
            Log.CloseAndFlush(); //To close our logger resource
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
            break;
    }
}