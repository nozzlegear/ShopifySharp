using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Collect")]
    public class Collect_Tests : IAsyncLifetime
    {
        /// <remarks>
        /// Hardcoded collection id used in previous versions was 27369427.
        /// </remarks>
        private long _CollectionId { get; set; }

        private long _ProductId { get; set; }

        private CollectService _Service => new CollectService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Collect> _Created => new List<Collect>();

        public async Task InitializeAsync()
        {
            // Create a product to use with these tests.
            var product = await new ProductService(Utils.MyShopifyUrl, Utils.AccessToken).CreateAsync(new ShopifySharp.Product()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                Vendor = "Burton",
                BodyHtml = "<strong>Good snowboard!</strong>",
                ProductType = "Snowboard",
                Images = new List<ProductImage> { new ProductImage { Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==" } },
            });

            // Create a collection to use with these tests.
            var collection = await new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken).CreateAsync(new CustomCollection()
            {
                Title = "Things",
                Published = false,
                Image = new CustomCollectionImage()
                {
                    Src = "http://placehold.it/250x250"
                }
            });

            _ProductId = product.Id.Value;
            _CollectionId = collection.Id.Value;

            // Create a collection to use with get, list, count, etc. tests.
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
                        Console.WriteLine($"Failed to delete created Collect with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }

            // Delete the product and the collect
            await new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken).DeleteAsync(_CollectionId);
            await new ProductService(Utils.MyShopifyUrl, Utils.AccessToken).DeleteAsync(_ProductId);
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Collect> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new Collect()
            {
                CollectionId = _CollectionId,
                ProductId = _ProductId,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Collects()
        {
            var count = await _Service.CountAsync();

            Assert.NotNull(count);
        }

        [Fact]
        public async Task Lists_Collects()
        {
            var collects = await _Service.ListAsync();

            Assert.True(collects.Count() > 0);
        }

        [Fact]
        public async Task Lists_Collects_With_A_Filter()
        {
            var collects = await _Service.ListAsync(new CollectFilter()
            {
                ProductId = _ProductId,
            });

            Assert.True(collects.Count() > 0);
            Assert.All(collects, collect => Assert.Equal(_ProductId, collect.ProductId));
        }

        [Fact]
        public async Task Gets_Collects()
        {
            var collect = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(collect);
            Assert.True(collect.Id.HasValue);
            Assert.Equal(_CollectionId, collect.CollectionId);
            Assert.Equal(_ProductId, collect.ProductId);
        }

        [Fact]
        public async Task Deletes_Collects()
        {
            var created = await Create(true);
            bool thrown = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.Write($"{nameof(Deletes_Collects)} failed. {ex.Message}.");
                
                thrown = true;
            }

            Assert.False(thrown);
        }

        [Fact]
        public async Task Creates_Collects()
        {
            var collect = await Create();

            Assert.NotNull(collect);
            Assert.True(collect.Id.HasValue);
            Assert.Equal(_CollectionId, collect.CollectionId);
            Assert.Equal(_ProductId, collect.ProductId);
        }
    }
}
