using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Customer")]
    public class Customer_Tests : IClassFixture<Customer_Tests_Fixture>
    {
        private Customer_Tests_Fixture Fixture { get; }

        public Customer_Tests(Customer_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Customers()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Customers()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Customers()
        {
            var created = await Fixture.Create();
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
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
            var customer = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

            Assert.NotNull(customer);
            Assert.Equal(Fixture.FirstName, customer.FirstName);
            Assert.Equal(Fixture.LastName, customer.LastName);
            Assert.Equal(Fixture.Note, customer.Note);
            Assert.NotNull(customer.Addresses);
            Assert.NotNull(customer.DefaultAddress);
        }

        [Fact]
        public async Task Gets_Customers_With_Options()
        {
            var customer = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value, "first_name,last_name");

            Assert.NotNull(customer);
            Assert.Equal(Fixture.FirstName, customer.FirstName);
            Assert.Equal(Fixture.LastName, customer.LastName);
            EmptyAssert.NullOrEmpty(customer.Note);
            EmptyAssert.NullOrEmpty(customer.Addresses);
            Assert.Null(customer.DefaultAddress);
            
        }

        [Fact]
        public async Task Creates_Customers()
        {
            var customer = await Fixture.Create();

            Assert.NotNull(customer);
            Assert.Equal(Fixture.FirstName, customer.FirstName);
            Assert.Equal(Fixture.LastName, customer.LastName);
            Assert.Equal(Fixture.Note, customer.Note);
            Assert.NotNull(customer.Addresses);
        }

        [Fact]
        public async Task Creates_Customers_With_Options()
        {
            var customer = await Fixture.Create(options: new CustomerCreateOptions()
            {
                Password = "loktarogar",
                PasswordConfirmation = "loktarogar",
                SendEmailInvite = false,
                SendWelcomeEmail = false,
            });

            Assert.NotNull(customer);
            Assert.Equal(Fixture.FirstName, customer.FirstName);
            Assert.Equal(Fixture.LastName, customer.LastName);
            Assert.Equal(Fixture.Note, customer.Note);
            Assert.NotNull(customer.Addresses);
        }

        [Fact]
        public async Task Updates_Customers()
        {
            string firstName = "Jane";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.FirstName = firstName;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(firstName, updated.FirstName);
        }

        [Fact]
        public async Task Updates_Customers_With_Options()
        {
            string firstName = "Jane";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.FirstName = firstName;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created, new CustomerUpdateOptions()
            {
                Password = "loktarogar",
                PasswordConfirmation = "loktarogar"
            });

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(firstName, updated.FirstName);
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
                var search = await Fixture.Service.SearchAsync("John");
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Searches_For_Customers)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }
    }

    public class Customer_Tests_Fixture : IAsyncLifetime
    {
        public CustomerService Service => new CustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Customer> Created { get; } = new List<Customer>();

        public string FirstName => "John";

        public string LastName => "Doe";

        public string Note => "Test note about this customer.";

        public async Task InitializeAsync()
        {
            // Create one customer for use with count, list, get, etc. tests.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in Created)
            {
                try
                {
                    await Service.DeleteAsync(obj.Id.Value);
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

        public async Task<Customer> Create(bool skipAddToCreatedList = false, CustomerCreateOptions options = null)
        {
            var obj = await Service.CreateAsync(new Customer()
            {
                FirstName = FirstName,
                LastName = LastName,
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
                Note = Note,
                State = "enabled"
            }, options);

            if (! skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
