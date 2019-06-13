using MVCAjax.Entities;
using MVCAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjax.Controllers
{
    public class HomeController : Controller
    {

        List<Customer> cusomterList = new List<Customer>()
        {
            new Customer { CustomerId=1111,CompanyName ="Company 1", ContactName="Contact 1", Country="UK" },
            new Customer { CustomerId=1114,CompanyName ="Company 2", ContactName="Contact 2", Country="US" }
        };

        List<Order> orderList = new List<Order>()
        {
            new Order { CustomerId=1111, OrderId = 1064, OrderDate=DateTime.Now.AddDays(-5),ShippingDate = DateTime.Now.AddDays(-3),ShippedTo="Germany" },
            new Order { CustomerId=1111, OrderId = 1066, OrderDate=DateTime.Now.AddDays(-5),ShippingDate = DateTime.Now.AddDays(-3),ShippedTo="US" },

            new Order { CustomerId=1114, OrderId = 1071, OrderDate=DateTime.Now.AddDays(-5),ShippingDate = DateTime.Now.AddDays(-3),ShippedTo="Germany" },
            new Order { CustomerId=1114, OrderId = 1075, OrderDate=DateTime.Now.AddDays(-5),ShippingDate = DateTime.Now.AddDays(-3),ShippedTo="UK" },
            new Order { CustomerId=1114, OrderId = 1086, OrderDate=DateTime.Now.AddDays(-5),ShippingDate = DateTime.Now.AddDays(-3),ShippedTo="US" },
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Demo()
        {
            ViewBag.Message = "Your contact page.";
            CustomerModel customerModel = new CustomerModel();
            customerModel.Customers = cusomterList;

            return View(customerModel);
        }


        public ActionResult GetView(string customerID, string viewName)
        {
            //object model = null;
            CustomerDetailsModel customerModel  = new CustomerDetailsModel();
            OrderModel orderModel = new OrderModel();
            if (viewName == "CustomerDetails")
            {
                customerModel.Customer = cusomterList.Where( x => x.CustomerId == Convert.ToInt32(customerID)).FirstOrDefault();

                return PartialView(viewName, customerModel);

            }
            if (viewName == "OrderDetails")
            {

                orderModel.Order = orderList.Where(x => x.CustomerId == Convert.ToInt32(customerID)).OrderBy(o => o.OrderId).ToList();

                return PartialView(viewName, orderModel);
            }

            return PartialView(viewName);
        }

    }
}