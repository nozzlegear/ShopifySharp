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

        [Fact]
        public void Lists_Carriers()
        {
            var list = Fixture.Service.ListAsync().Result;

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public void Gets_Carriers()
        {
            var created = Fixture.Create();

            var carrier = Fixture.Service.GetAsync(created.Id.Value).Result;

            Assert.NotNull(carrier);
            Assert.True(carrier.Id.HasValue);
            Assert.Equal(Fixture.CallbackUrl, carrier.CallbackUrl);
        }

        [Fact]
        public void Deletes_Carriers()
        {
            var created = Fixture.Create(true);
            bool threw = false;

            try
            {
                Fixture.Service.DeleteAsync(created.Id.Value).GetAwaiter().GetResult();

                var stillThere = Fixture.Service.GetAsync(created.Id.Value).Result;

                Assert.Null(stillThere);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Carriers)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }


        [Fact]
        public void Creates_Carriers()
        {
            var carrier = Fixture.Create();

            Assert.NotNull(carrier);
            Assert.True(carrier.Id.HasValue);
            Assert.Equal(Fixture.CallbackUrl, carrier.CallbackUrl);
        }

        [Fact]
        public void Updates_Carriers()
        {
            string newCallbackUrl = "http://fakecallback2.com/";
            var created = Fixture.Create();
            long id = created.Id.Value;

            created.CallbackUrl = newCallbackUrl;
            created.Id = null;

            var updated = Fixture.Service.UpdateAsync(id, created).Result;

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(newCallbackUrl, updated.CallbackUrl);   
        }
    }

    public class Carrier_Tests_Fixture : IDisposable
    {
        public CarrierService Service { get; } = new CarrierService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Carrier> Created { get; } = new List<Carrier>();

        public string CallbackUrl => "http://fakecallback.com/";

        public void Dispose()
        {
            foreach (var obj in Created)
            {
                try
                {
                    Service.DeleteAsync(obj.Id.Value).GetAwaiter().GetResult();
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created CustomCollection with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public Carrier Create(bool skipAddToCreatedList = false)
        {
            var obj = Service.CreateAsync(new Carrier()
            {
                Name = "Test Carrier",
                Active = true,
                CallbackUrl = CallbackUrl,
                CarrierServiceType = "api",
                ServiceDiscovery = true,
                Format = "json"    
            }).Result;

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}