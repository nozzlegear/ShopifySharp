using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class CustomerCreation
    {
        public static ShopifyCustomer CreateValidCustomer()
        {
            return new ShopifyCustomer()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = Guid.NewGuid().ToString() + "@example.com",
                Addresses = new List<ShopifyAddress>()
                {
                    new ShopifyAddress()
                    {
                        Address1 = "123 4th Street",
                        City = "Minneapolis",
                        Province = "Minnesota",
                        ProvinceCode = "MN",
                        Zip = "55401",
                        Phone = "555-555-5555",
                        FirstName = "John",
                        LastName = "Doe",
                        Company = "Tomorrow Corporation",
                        Country = "United States",
                        CountryCode = "US",
                        Default = true,
                    }
                },
                VerifiedEmail = true,
                Note = "Test note about the customer.",
                State = "enabled"
            };
        }
    }
}
