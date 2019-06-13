using MVCAjax.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAjax.Models
{
    public class CustomerModel
    {
        public List<Customer> Customers { get; set; }
    }


    public class CustomerDetailsModel
    {
        public Customer Customer { get; set; }
    }
}