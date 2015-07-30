using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class CustomerCreation
    {
        public static ShopifyCustomer ValidCustomer = new ShopifyCustomer()
        {
            FirstName = "Josh",
            LastName = "Harms",
            Email = "nozzlegear@outlook.com",
            DefaultAddress = new ShopifyAddress()
            {
                Address1 = "123 4th Street",
                Address2 = "Building 5",
                City = "Minneapolis",
                Province = "Minnesota",
                ProvinceCode = "MN",
                Phone = "555-555-5555",
                FirstName = "Josh",
                LastName = "Harms",
                Company = "Nozzlegear Software",
                Country = "United States",
                CountryCode = "US",
                Default = true,
            },
            VerifiedEmail = true,
            Note = "Test note about the customer.",
            State = "enabled"
        };
    }
}
