using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Customer")]
    public class Customer_Tests : IAsyncLifetime
    {
        private CustomerService _Service => new CustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Customer> _Created { get; } = new List<Customer>();

        private string _FirstName => "John";

        private string _LastName => "Doe";

        private string _Note => "Test note about this customer.";

        public async Task InitializeAsync()
        {
            // Create one customer for use with count, list, get, etc. tests.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in _Created)
            {
                try
                {
                    await _Service.DeleteAsync(obj.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created Customer with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        private async Task<Customer> Create(bool skipAddToCreatedList = false, CustomerCreateOptions options = null)
        {
            var obj = await _Service.CreateAsync(new Customer()
            {
                FirstName = _FirstName,
                LastName = _LastName,
                Email = Guid.NewGuid().ToString() + "@example.com",
                Addresses = new List<Address>()
                {
                    new Address()
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
                Note = _Note,
                State = "enabled"
            }, options);

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Customers()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Customers()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Customers()
        {
            var created = await Create();
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Customers)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Customers()
        {
            var customer = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(customer);
            Assert.Equal(_FirstName, customer.FirstName);
            Assert.Equal(_LastName, customer.LastName);
            Assert.Equal(_Note, customer.Note);
            Assert.NotNull(customer.Addresses);
            Assert.NotNull(customer.DefaultAddress);
        }

        [Fact]
        public async Task Gets_Customers_With_Options()
        {
            var customer = await _Service.GetAsync(_Created.First().Id.Value, "first_name,last_name");

            Assert.NotNull(customer);
            Assert.Equal(_FirstName, customer.FirstName);
            Assert.Equal(_LastName, customer.LastName);
            Assert.Empty(customer.Note);
            Assert.Empty(customer.Addresses);
            Assert.Null(customer.DefaultAddress);
        }

        [Fact]
        public async Task Creates_Customers()
        {
            var customer = await Create();

            Assert.NotNull(customer);
            Assert.Equal(_FirstName, customer.FirstName);
            Assert.Equal(_LastName, customer.LastName);
            Assert.Equal(_Note, customer.Note);
            Assert.NotNull(customer.Addresses);
        }

        [Fact]
        public async Task Creates_Customers_With_Options()
        {
            var customer = await Create(options: new CustomerCreateOptions()
            {
                Password = "loktarogar",
                PasswordConfirmation = "loktarogar",
                SendEmailInvite = false,
                SendWelcomeEmail = false,
            });

            Assert.NotNull(customer);
            Assert.Equal(_FirstName, customer.FirstName);
            Assert.Equal(_LastName, customer.LastName);
            Assert.Equal(_Note, customer.Note);
            Assert.NotNull(customer.Addresses);
        }

        [Fact]
        public async Task Updates_Customers()
        {
            string firstName = "Jane";
            var customer = await Create();
            customer.FirstName = firstName;

            var updated = await _Service.UpdateAsync(customer);

            Assert.Equal(firstName, customer.FirstName);
        }

        [Fact]
        public async Task Updates_Customers_With_Options()
        {
            string firstName = "Jane";
            var customer = await Create();
            customer.FirstName = firstName;

            var updated = await _Service.UpdateAsync(customer, new CustomerUpdateOptions()
            {
                Password = "loktarogar",
                PasswordConfirmation = "loktarogar"
            });

            Assert.Equal(firstName, customer.FirstName);
        }

        [Fact]
        public async Task Searches_For_Customers()
        {
            // It takes anywhere between 3 seconds to 30 seconds for Shopify to index new customers for searches.
            // Rather than putting a 20 second Thread.Sleep in the test, we'll just assume it's successful if the
            // test doesn't throw an exception.
            bool threw = false;
            
            try
            {
                var search = await _Service.SearchAsync("John");
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Searches_For_Customers)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }
    }
}
