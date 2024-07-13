using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Country { get; set; }

        public List<Customer> GetCustomers()
        {
            var response = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId=1,
                    CustomerName="anudeep",
                    Country="india"
                },
                new Customer()
                {
                    CustomerId=2,
                    CustomerName="sandeep",
                    Country="usa"
                },
            };
            return response;
        }
    }
}