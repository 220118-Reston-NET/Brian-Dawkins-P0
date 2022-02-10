﻿using CustomerModel;
using OrderModel;
using StoreFrontModel;

namespace StoreAppDL
{
    /// <summary>
    ///- Data layer project is responsible for interacting with our database and doing CRUD operations
    ///- C - create, R - Read, U - Update, D - Delete
    ///- It must not have logical operation that will also manipulate the data it is grabbing
    ///- Just think of Data layer as the delivery man of your uber eats. You definitely dont want your delivery man to touch
    /// the food he is delivering and just give it to you so you can do whatever you want with it.   
    /// </summary>
public interface IRepository
{
    /// <summary>
    /// Add a customer to the database
    /// </summary>
    /// <param name="c_customer"></param>
    /// <returns></returns>
    Customer AddCustomer(Customer c_customer);

    /// <summary>
    /// Will give all customers in the database
    /// </summary>
    /// <returns></returns>
    List<Customer> GetAllCustomers();

    /// <summary>
    /// Will give a list of orders from a customer
    /// </summary>
    /// <param name="c_customerId">The Id of the customer it will search</param>
    /// <returns>list collection that holds order objects</returns>
    List<Orders> GetOrdersByCustomerId(int c_customerId);

    List<StoreFront> GetAllStores();
    List<StoreFront> ViewInventory(int c_storeId);
}
}