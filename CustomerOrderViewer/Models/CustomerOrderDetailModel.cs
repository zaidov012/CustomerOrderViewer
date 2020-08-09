using System;
using System.Collections.Generic;
using System.Text;

/*
 * What is a CustomerOrderDetailModel?
 * It's a class, which need to read the data from db
 * We know how the data stored in db ( sBecause we have stored them into ourselves :) )
 * And we create properties for get each item in a row
 * This class will be needed to generate a list with CustomerOrderDetailModel type
*/

namespace CustomerOrderViewer.Models
{
    class CustomerOrderDetailModel
    {
        public int CustomerOrderId { get; set; }

        public int CustomerId { get; set; }

        public int ItemId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


    }
}
