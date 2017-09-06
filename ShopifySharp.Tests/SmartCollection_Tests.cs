using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "SmartCollection")]
    public class SmartCollection_Tests : IClassFixture<SmartCollection_Tests_Fixture>
    {
        private SmartCollection_Tests_Fixture Fixture { get; }

        public SmartCollection_Tests(SmartCollection_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_SmartCollections()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_SmartCollections()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_SmartCollections()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_SmartCollections)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_SmartCollections()
        {
            var created = await Fixture.Create();
            var obj = await Fixture.Service.GetAsync(created.Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.BodyHtml, obj.BodyHtml);
            Assert.Equal(Fixture.Title, obj.Title);
            Assert.StartsWith(Fixture.Handle, obj.Handle, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public async Task Creates_SmartCollections()
        {
            var obj = await Fixture.Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.BodyHtml, obj.BodyHtml);
            Assert.Equal(Fixture.Title, obj.Title);
            Assert.StartsWith(Fixture.Handle, obj.Handle, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public async Task Updates_SmartCollections()
        {
            string newValue = "New Title";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Title = newValue;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(newValue, updated.Title);   
        }
    }

    public class SmartCollection_Tests_Fixture : IAsyncLifetime
    {
        public SmartCollectionService Service { get; } = new SmartCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<SmartCollection> Created { get; } = new List<SmartCollection>();

        public string BodyHtml => "<h1>Hello world!</h1>";

        public string Handle => "ShopifySharp-Handle";

        public string Title => "ShopifySharp Test Smart Collection";

        public async Task InitializeAsync()
        {
            // Create one collection for use with count, list, get, etc. tests.
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
                        Console.WriteLine($"Failed to delete created SmartCollection with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<SmartCollection> Create(bool skipAddToCreatedList = false)
        {
            var obj = await Service.CreateAsync(new SmartCollection()
            {
                BodyHtml =  BodyHtml,
                Handle = Handle,
                Title = Title,
            });

            if (! skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}