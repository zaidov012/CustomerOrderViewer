using CustomerOrderViewer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

/*
 * Why we need this class CustomerOrderDetailCommand ? 
 * We have three other types to
 *      a) connect to db
 *      b) create a command
 *      c) run the command and get data from db
 * So, this class will unite them all and only thing we need to do, will be:
 *      a) Instantiate an object of this class
 *      b) As a parameter pass the connection string to db
 *      c) Execute the methods (like GetList() and etc. )
*/

namespace CustomerOrderViewer.Repositories
{
    class CustomerOrderDetailCommand
    {
        string _connectionString;

        public CustomerOrderDetailCommand(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<CustomerOrderDetailModel> GetList()
        {
            List<CustomerOrderDetailModel> customerOrderDetailModels = new List<CustomerOrderDetailModel>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM CustomerOrderDetail", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CustomerOrderDetailModel customerOrderDetailModel = new CustomerOrderDetailModel()
                                {
                                    CustomerOrderId = Convert.ToInt32(reader["CustomerOrderId"]),
                                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                    ItemId = Convert.ToInt32(reader["ItemId"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"])
                                };

                                customerOrderDetailModels.Add(customerOrderDetailModel);
                            }
                        }
                    }
                }
            }

            return customerOrderDetailModels;
        }
    }
}
