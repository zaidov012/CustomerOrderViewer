using CustomerOrderViewer.Models;
using CustomerOrderViewer.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomerOrderViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a command for get all data from a db. Command has written inside a class. We just need to put a connection string
            CustomerOrderDetailCommand customerOrderDetailCommand = new CustomerOrderDetailCommand(@"Data Source=localhost;Initial Catalog=CustomerOrderViewer;Integrated Security=True");

            /*
             * Create a list for hold the data from db. GetList() method:
                 * a) connects to db with using connections string
                 * b) generates a command ("SELECT") to get all the data
                 * c) generates a 'DataReader' which gets all the data
                 * d) creates a list and writes each row from db as an item in list
                 * e) returns IList<CustomerOrderDetailModel> type list with all the data 
             */
            IList<CustomerOrderDetailModel> customerOrderDetailModels = customerOrderDetailCommand.GetList();

            // if we have any elements in the list, so...
            if(customerOrderDetailModels.Any())
            {
                // get items and work on it to WriteLine on a Console
                foreach(var item in customerOrderDetailModels)
                {
                    Console.WriteLine(
                        "OrderID: {0, -3}\tFullName: {1, -10}{2, -15}ID: {3, -3}\tPurchased: {4, -15}${5, -8} ItemID: {6}",
                        item.CustomerOrderId,
                        item.FirstName,
                        item.LastName,
                        item.CustomerId,
                        item.Description,
                        item.Price,
                        item.ItemId
                        );
                }
            }
        }
    }
}
