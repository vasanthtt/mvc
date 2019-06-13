using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAjax.Entities
{
    public class Order
    {
        
        public int CustomerId { get; set; }
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public string  ShippedTo { get; set; }
    }
}