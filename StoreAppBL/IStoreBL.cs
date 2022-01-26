using StoreFrontModel;

namespace StoreBL
{

/// <summary>
/// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
/// What kind of processing? That all depends on the type of functionality you will be doing
/// </summary>
public interface IStoreBL
{
    /// <summary>
    /// Will add a customer to the database
    /// Initial addition of a pokemon will give it some sort of a randomize stats
    /// Can only have the total of 4 pokemons in the database
    /// </summary>
    /// <param name="c_customer"></param>
    /// <returns></returns>
    Customer AddCustomer(Customer c_customer);
    }
}