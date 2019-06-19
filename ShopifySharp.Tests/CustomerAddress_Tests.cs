using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "CustomerAddress")]
    public class CustomerAddress_Tests : IClassFixture<CustomerAddress_Tests_Fixture>
    {
        private CustomerAddress_Tests_Fixture Fixture { get; }

        public CustomerAddress_Tests(CustomerAddress_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Lists_Addresses()
        {
            var Addresss = await Fixture.Service.ListAsync(Fixture.CustomerId.Value);

            Assert.True(Addresss.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Addresses()
        {
            var created = await Fixture.Create(Fixture.RandomStreetAddress(), true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(Fixture.CustomerId.Value, created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Addresses)} threw exception. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Addresses()
        {
            var streetAddress = Fixture.RandomStreetAddress();
            var created = await Fixture.Create(streetAddress);
            var address = await Fixture.Service.GetAsync(Fixture.CustomerId.Value, created.Id.Value);

            Assert.NotNull(address);
            Assert.Equal(streetAddress, address.Address1);
            Assert.Equal(Fixture.FirstName, address.FirstName);
            Assert.Equal(Fixture.LastName, address.LastName);
        }

        [Fact]
        public async Task Creates_Addresses()
        {
            var streetAddress = Fixture.RandomStreetAddress();
            var created = await Fixture.Create(streetAddress);

            Assert.NotNull(created);
            Assert.Equal(streetAddress, created.Address1);
            Assert.Equal(Fixture.FirstName, created.FirstName);
            Assert.Equal(Fixture.LastName, created.LastName);
        }

        [Fact]
        public async Task Updates_Addresss()
        {
            string firstName = "Jane";
            string lastName = "Doe";
            string fullName = "Jane Doe";
            var created = await Fixture.Create(Fixture.RandomStreetAddress());
            long id = created.Id.Value;

            created.FirstName = firstName;
            created.LastName = lastName;
            created.Name = fullName;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(Fixture.CustomerId.Value, id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(firstName, updated.FirstName);
        }
    }

    public class CustomerAddress_Tests_Fixture : IAsyncLifetime
    {
        public CustomerAddressService Service { get; } = new CustomerAddressService(Utils.MyShopifyUrl, Utils.AccessToken);

        public string FirstName => "John";

        public string LastName => "Doe";

        public long? CustomerId { get; set; }

        public List<Address> Created { get; } = new List<Address>();

        Random Randomizer { get; } = new Random();

        public string RandomStreetAddress() => $"{Randomizer.Next(1, 9999)} 99th St";

        public async Task InitializeAsync()
        {
            var customerService = new CustomerService(Utils.MyShopifyUrl, Utils.AccessToken);
            var customers = await customerService.ListAsync();

            CustomerId = customers.First().Id;

            // Create at least one Address for list, count, etc commands.
            //await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var Address in Created)
            {
                try
                {
                    await Service.DeleteAsync(CustomerId.Value, Address.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete CustomerAddress with id {Address.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Gets an object from the list of already created objects, or creates the object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Address> Create(string streetAddress, bool skipAddToDeleteList = false)
        {
            var obj = await Service.CreateAsync(CustomerId.Value, new Address()
            {
                Address1 = streetAddress,
                City = "Minneapolis",
                Province = "Minnesota",
                ProvinceCode = "MN",
                Zip = "55401",
                Phone = "555-555-5555",
                FirstName = FirstName,
                LastName = LastName,
                Company = "Tomorrow Corporation",
                Country = "United States",
                CountryCode = "US",
            });

            if (!skipAddToDeleteList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
