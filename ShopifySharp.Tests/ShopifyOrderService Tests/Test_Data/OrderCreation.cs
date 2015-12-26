using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Test_Data
{
    public static class OrderCreation
    {
        /// <summary>
        /// Generates a valid <see cref="ShopifyOrder"/> for testing the Order API.
        /// </summary>
        public static ShopifyOrder GenerateOrder()
        {
            return new ShopifyOrder()
            {
                CreatedAt = DateTime.UtcNow,
                BillingAddress = new ShopifyAddress()
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
                },
                LineItems = new List<ShopifyLineItem>()
                {
                    new ShopifyLineItem()
                    {
                        Name = "Test Line Item",
                        Title = "Test Line Item Title",
                        Quantity = 2,
                        Price = 5
                    },
                    new ShopifyLineItem()
                    {
                        Name = "Test Line Item 2",
                        Title = "Test Line Item Title 2",
                        Quantity = 2,
                        Price = 5
                    }
                },
                FinancialStatus = Enums.ShopifyOrderFinancialStatus.Paid,
                TotalPrice = 5.00,
                Transactions = new List<ShopifyTransaction>()
                {
                    new ShopifyTransaction()
                    {
                        Amount = 20.00,
                        Status = "success",
                        Kind = Enums.ShopifyTransactionKind.Authorization,
                        Test = true,
                    }
                },
                Email = Guid.NewGuid().ToString() + "@example.com",
                Note = "Test note about the customer.",
            };
        }
    }
}
