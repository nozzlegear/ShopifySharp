using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;
using Xunit.Abstractions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Collect")]
    public class Collect_Tests : IClassFixture<Collect_Tests_Fixture>
    {
        private Collect_Tests_Fixture Fixture { get; }
        private readonly ITestOutputHelper _testOutputHelper;

        public Collect_Tests(Collect_Tests_Fixture fixture, ITestOutputHelper testOutputHelper)
        {
            this.Fixture = fixture;
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task Counts_Collects()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count >= 0);
        }

        [Fact]
        public async Task Lists_Collects()
        {
            var collects = await Fixture.Service.ListAsync();

            Assert.True(collects.Items.Any());
        }

        [Fact]
        public async Task Lists_Collects_With_A_Filter()
        {
            var productId = Fixture.Created.First().ProductId;
            var collects = await Fixture.Service.ListAsync(new CollectListFilter()
            {
                ProductId = productId,
            });

            Assert.True(collects.Items.Any());
            Assert.All(collects.Items, collect => Assert.True(collect.ProductId > 0));
        }

        [Fact]
        public async Task Gets_Collects()
        {
            var collect = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

            Assert.NotNull(collect);
            Assert.True(collect.Id.HasValue);
            Assert.Equal(Fixture.CollectionId, collect.CollectionId);
            Assert.True(collect.ProductId > 0);
        }

        [Fact]
        public async Task Deletes_Collects()
        {
            var created = await Fixture.Create(true);
            bool thrown = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                _testOutputHelper.WriteLine($"{nameof(Deletes_Collects)} failed. {ex.Message}.");

                thrown = true;
            }

            Assert.False(thrown);
        }

        [Fact]
        public async Task Creates_Collects()
        {
            var collect = await Fixture.Create();

            Assert.NotNull(collect);
            Assert.True(collect.Id.HasValue);
            Assert.Equal(Fixture.CollectionId, collect.CollectionId);
            Assert.True(collect.ProductId > 0);
        }
    }

    public class Collect_Tests_Fixture : IAsyncLifetime
    {
        public CollectService Service { get; } = new CollectService(Utils.MyShopifyUrl, Utils.AccessToken);

        public CustomCollectionService CustomCollectionService { get; } = new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        public ProductService ProductService { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Collect> Created { get; } = new List<Collect>();

        /// <remarks>
        /// Hardcoded collection id used in previous versions was 27369427.
        /// </remarks>
        public long CollectionId { get; set; }

        public async Task InitializeAsync()
        {
            var policy = new LeakyBucketExecutionPolicy();

            Service.SetExecutionPolicy(policy);
            ProductService.SetExecutionPolicy(policy);
            CustomCollectionService.SetExecutionPolicy(policy);

            // Create a collection to use with these tests.
            var collectionHandle = Guid.NewGuid().ToString();
            var collection = await CustomCollectionService.CreateAsync(new CustomCollection()
            {
                Title = "Things",
                Handle = collectionHandle,
                Published = false,
                Image = new CustomCollectionImage()
                {
                    Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="
                }
            });

            CollectionId = collection.Id.Value;

            // Create a collection to use with get, list, count, etc. tests.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in Created)
            {
                try
                {
                    await Service.DeleteAsync(obj.Id.Value);
                    await ProductService.DeleteAsync(obj.ProductId.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created Collect with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }

            // Delete the collection
            try
            {
                await CustomCollectionService.DeleteAsync(CollectionId);
            }
            catch (ShopifyException ex) when ((int)ex.HttpStatusCode == 404)
            {
                // Collection has already been deleted
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Collect> Create(bool skipAddToCreatedList = false)
        {
            // Create a product to use with these tests.
            var product = await ProductService.CreateAsync(new ShopifySharp.Product()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                Vendor = "Burton",
                BodyHtml = "<strong>Good snowboard!</strong>",
                ProductType = "Snowboard",
                Handle = Guid.NewGuid().ToString(),
                Images = new List<ProductImage> { new ProductImage { Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==" } },
                PublishedScope = "published"
            });
            var obj = await Service.CreateAsync(new Collect()
            {
                CollectionId = CollectionId,
                ProductId = product.Id.Value,
            });

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
