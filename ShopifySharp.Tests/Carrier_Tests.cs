using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Carrier")]
    public class Carrier_Tests : IClassFixture<Carrier_Tests_Fixture>
    {
        private Carrier_Tests_Fixture Fixture { get; }

        public Carrier_Tests(Carrier_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact(Skip = "Shopify won't let us create more than one random carrier.")]
        public async Task Lists_Carriers()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Count() >= 0);
        }

        [Fact(Skip = "Shopify won't let us create more than one random carrier.")]
        public async Task Gets_Carriers()
        {
            var created = await Fixture.Create();
            var carrier = await Fixture.Service.GetAsync(created.Id.Value);
            await Fixture.Service.DeleteAsync(created.Id.Value);

            Assert.NotNull(carrier);
            Assert.True(carrier.Id.HasValue);
            Assert.Contains(Fixture.CallbackUrl, carrier.CallbackUrl);
        }

        [Fact(Skip = "Shopify won't let us create more than one random carrier.")]
        public async Task Deletes_Carriers()
        {
            var created = await Fixture.Create();
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Carriers)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }


        [Fact(Skip = "Shopify won't let us create more than one random carrier.")]
        public async Task Creates_Carriers()
        {
            var carrier = await Fixture.Create();
            await Fixture.Service.DeleteAsync(carrier.Id.Value);

            Assert.NotNull(carrier);
            Assert.True(carrier.Id.HasValue);
            Assert.Contains(Fixture.CallbackUrl, carrier.CallbackUrl);
        }

        [Fact(Skip = "Shopify won't let us create more than one random carrier.")]
        public async Task Updates_Carriers()
        {
            string newCallbackUrl = "http://fakecallback2.com/";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.CallbackUrl = newCallbackUrl;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);
            await Fixture.Service.DeleteAsync(updated.Id.Value);

            Assert.Equal(newCallbackUrl, updated.CallbackUrl);
        }
    }

    public class Carrier_Tests_Fixture
    {
        public CarrierService Service { get; } = new CarrierService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Carrier> Created { get; } = new List<Carrier>();

        public string CallbackUrl => "http://fakecallback.com/";

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
                        Console.WriteLine($"Failed to delete Carrier with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Carrier> Create()
        {
            string uid = Guid.NewGuid().ToString();
            string name = $"DERP DERP {uid}";
            string cb = $"{CallbackUrl}{uid}";

            var obj = await Service.CreateAsync(new Carrier()
            {
                Name = name,
                Active = false,
                CallbackUrl = cb,
                CarrierServiceType = "api",
                ServiceDiscovery = true,
                Format = "json"
            });

            return obj;
        }
    }
}
