using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class PackageOrder
    {
        public string OrderId { get; set; }
        public class Customer {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public class ShippingAddress
            {
                public string AddressLine1 { get; set; }
                public string AddressLine2 { get; set; }
                public string City { get; set; }
                public string State { get; set; }
                public int Zip { get; set; }
            }
        }
        //public List<string> LineItems
        //{ }
        //public string Sku { get; set; }
        //public int Quantity { get; set; }
        //public decimal UnitPrice { get; set; }
        //public decimal TotalPrice { get; set; }
        //public LineItems() { }
        //public LineItems(
        //    string sku,
        //    int quantity,
        //    decimal unitPrice,
        //    decimal totalPrice
        //    )
        //{
        //    Sku = sku;
        //    Quantity = quantity;
        //    UnitPrice = unitPrice;
        //    TotalPrice = totalPrice;
        //}
    }
}
