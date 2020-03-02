using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "FulfillmentService")]
    public class FulfillmentService_Tests : IClassFixture<FulfillmentService_Tests_Fixture>
    {
        private FulfillmentService_Tests_Fixture Fixture { get; }

        public FulfillmentService_Tests(FulfillmentService_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }


        [Fact]
        public async Task Lists_FulfillmentServices()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Lists_All_FulfillmentServices()
        {
            var list = await Fixture.Service.ListAsync(new FulfillmentServiceListFilter
            {
                Scope = "all"
            });
            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Gets_FulfillmentServices()
        {
            // Find an id 
            var created = Fixture.Created.First();
            var fulfillmentServiceEntity = await Fixture.Service.GetAsync(created.Id.Value);

            Assert.NotNull(fulfillmentServiceEntity);
        }

        [Fact]
        public async Task Creates_FulfillmentServices()
        {
            var created = await Fixture.Create();

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
        }


        [Fact]
        public async Task Updates_FulfillmentServices()
        {
            string name = "Auntie Dot's Fulfillment Company";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Name = name;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(name, updated.Name);
        }

    }

    public class FulfillmentService_Tests_Fixture : IAsyncLifetime
    {
        public FulfillmentServiceService Service { get; } = new FulfillmentServiceService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<FulfillmentServiceEntity> Created { get; } = new List<FulfillmentServiceEntity>();

        public async Task InitializeAsync()
        {
            // Fulfillment API has a stricter rate limit when on a non-paid store.
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            // Create a fulfillment service for count, list, get, etc. tests.
            var fulfillmentServiceEntity = await Create();
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
                    Console.WriteLine($"Failed to delete fulfillment service with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }

        public async Task<FulfillmentServiceEntity> Create(bool skipAddToCreateList = false)
        {
            FulfillmentServiceEntity fulfillmentServiceEntity = await Service.CreateAsync(new FulfillmentServiceEntity()
            {
                Name = $"MarsFulfillment{DateTime.Now.Ticks}",
                CallbackUrl = "http://google.com",
                InventoryManagement = false,
                TrackingSupport = false,
                RequiresShippingMethod = false,
                Format = "json",
            });

            if (!skipAddToCreateList) Created.Add(fulfillmentServiceEntity);

            return fulfillmentServiceEntity;
        }
    }
}
