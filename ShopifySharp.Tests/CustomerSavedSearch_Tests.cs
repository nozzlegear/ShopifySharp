using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "CustomerSavedSearchavedSearch")]
    public class CustomerSavedSearch_Tests : IClassFixture<CustomerSavedSearch_Tests_Fixture>
    {
        private CustomerSavedSearch_Tests_Fixture Fixture { get; }

        public CustomerSavedSearch_Tests(CustomerSavedSearch_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_CustomerSavedSearch()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_CustomerSavedSearch()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Items.Any());
        }

        [Fact]
        public async Task Deletes_CustomerSavedSearch()
        {
            var created = await Fixture.Create();

            await Fixture.Service.DeleteAsync(created.Id.Value);
        }

        [Fact]
        public async Task Gets_CustomerSavedSearch()
        {
            var customerSavedSearch = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

            Assert.NotNull(customerSavedSearch);
            Assert.StartsWith(Fixture.NamePrefix, customerSavedSearch.Name);
            Assert.Equal(Fixture.Query, customerSavedSearch.Query);
        }

        [Fact]
        public async Task Creates_CustomerSavedSearch()
        {
            var customerSavedSearch = await Fixture.Create();

            Assert.NotNull(customerSavedSearch.Name);
            Assert.StartsWith(Fixture.Name, customerSavedSearch.Name);
            Assert.Equal(Fixture.Query, customerSavedSearch.Query);
        }

        [Fact]
        public async Task Updates_CustomerSavedSearch()
        {
            string name = "newName";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Name = name;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(name, updated.Name);
        }

        [Fact]
        public async Task Can_Be_Partially_Updated()
        {
            string newQuery = "notes=yes";
            var created = await Fixture.Create();
            var updated = await Fixture.Service.UpdateAsync(created.Id.Value, new CustomerSavedSearch()
            {
                Query = newQuery
            });

            Assert.Equal(created.Id, updated.Id);
            Assert.Equal(newQuery, updated.Query);
            Assert.Equal(created.Name, updated.Name);
        }

        [Fact]
        public async Task Retrieves_Customers_In_A_Saved_Search()
        {
            var customerFixture = new Customer_Tests_Fixture();
            var expectedCustomer = customerFixture.Create();
            var savedSearch = await Fixture.Create();

            var customersInSearch = await Fixture.Service.GetCustomersFromSavedSearchAsync(savedSearch.Id.Value);
            var actualCustomer = customersInSearch.Single();

            Assert.Equal(expectedCustomer.Id, actualCustomer.Id);
            Assert.Equal(customerFixture.FirstName, actualCustomer.FirstName);
            Assert.Equal(customerFixture.LastName, actualCustomer.LastName);
            Assert.Equal(customerFixture.Note, actualCustomer.Note);
        }
    }

    public class CustomerSavedSearch_Tests_Fixture : IAsyncLifetime
    {
        public CustomerSavedSearchService Service { get; } = new CustomerSavedSearchService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<CustomerSavedSearch> Created { get; } = new List<CustomerSavedSearch>();

        public string NamePrefix => "Test Notes ";
        public string Query => "-notes";

        public async Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

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
                        Console.WriteLine($"Failed to delete created CustomerSavedSearchavedSearch with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        public async Task<CustomerSavedSearch> Create(bool skipAddToCreatedList = false)
        {
            var obj = await Service.CreateAsync(new CustomerSavedSearch()
            {
                // Max length for a saved search is 40 chars
                Name = (NamePrefix + Guid.NewGuid()).Substring(0, 39),
                Query = "-notes"
            });

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
