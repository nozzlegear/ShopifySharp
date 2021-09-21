using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
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

            Assert.True(list.Items.Count() > 0);
        }

        [Fact]
        public async Task Deletes_SmartCollections()
        {
            var created = await Fixture.Create(true, true);
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
            Assert.NotNull(obj.PublishedAt);
            Assert.NotNull(obj.PublishedScope);
        }

        [Fact]
        public async Task Creates_Unpublished_SmartCollections()
        {
            var obj = await Fixture.Create(false);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.BodyHtml, obj.BodyHtml);
            Assert.Equal(Fixture.Title, obj.Title);
            Assert.StartsWith(Fixture.Handle, obj.Handle, StringComparison.OrdinalIgnoreCase);
            Assert.Null(obj.PublishedAt);
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

        [Fact]
        public async Task Publishes_SmartCollections()
        {
            var created = await Fixture.Create(false);

            Assert.Null(created.PublishedAt);

            var updated = await Fixture.Service.PublishAsync(created.Id.Value);

            Assert.NotNull(updated.PublishedAt);
        }

        [Fact]
        public async Task Unpublishes_SmartCollections()
        {
            var created = await Fixture.Create(true);

            Assert.NotNull(created.PublishedAt);

            var updated = await Fixture.Service.UnpublishAsync(created.Id.Value);

            Assert.Null(updated.PublishedAt);
        }

        [Fact(Skip = "This test has a bit of a time delay that ShopifySharp isn't equipped to handle yet (Retry-After header).")]
        public async Task Updates_SmartCollection_Products_Order()
        {
            //generate a unique tag
            var tag = Guid.NewGuid().ToString();

            //create collection
            var collection = await Fixture.Service.CreateAsync(new SmartCollection()
            {
                BodyHtml = Fixture.BodyHtml,
                Handle = Fixture.Handle,
                Title = Fixture.Title,
                Rules = new List<SmartCollectionRules>
                {
                    new SmartCollectionRules
                    {
                        Column = "tag",
                        Condition = tag,
                        Relation = "equals"
                    }
                }
            });

            //create 4 products with unique tag
            var productService = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            var products = new List<Product>();
            for (var i = 0; i < 4; i++)
            {
                var product = await productService.CreateAsync(new Product()
                {
                    Title = Guid.NewGuid().ToString(),
                    Tags = tag
                });
                products.Add(product);
            }

            //reorder items
            products.Reverse();
            var productIds = products.Select(p => p.Id.Value).ToArray();
            await Fixture.Service.UpdateProductOrderAsync(collection.Id.Value, "manual", productIds);


            //get collection
            collection = await Fixture.Service.GetAsync(collection.Id.Value);

            //get products  - use collect service to get products so they are returned in order
            var collectService = new CollectService(Utils.MyShopifyUrl, Utils.AccessToken);
            var collects = (await collectService.ListAsync(new CollectListFilter { CollectionId = collection.Id })).Items.ToList();

            //check
            Assert.Equal("manual", collection.SortOrder);
            collects.ForEach(c => Assert.True(productIds.Contains(c.ProductId.Value)));

            //delete the objects
            await Fixture.Service.DeleteAsync(collection.Id.Value);
            products.ForEach(async x => await productService.DeleteAsync(x.Id.Value));

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
            Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

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
        public async Task<SmartCollection> Create(bool published = true, bool skipAddToCreatedList = false)
        {
            var obj = await Service.CreateAsync(new SmartCollection()
            {
                BodyHtml = BodyHtml,
                Handle = Handle,
                Title = Title,
                Rules = new List<SmartCollectionRules>
                {
                    new SmartCollectionRules
                    {
                        Column = "variant_price",
                        Condition = "20",
                        Relation = "less_than"
                    }
                }
            }, published);

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}