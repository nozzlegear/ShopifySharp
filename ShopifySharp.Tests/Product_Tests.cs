using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Product")]
    public class Product_Tests : IAsyncLifetime
    {
        private ProductService _Service => new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Product> _Created { get; } = new List<Product>();

        private string _Title => "ShopifySharp Test Product";

        private string _Vendor = "Auntie Dot";

        private string _BodyHtml => "<strong>This product was created while testing ShopifySharp!</strong>";

        private string _ProductType => "Foobars";

        public async Task InitializeAsync()
        {
            // Create one for count, list, get, etc. orders.
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
                        Console.WriteLine($"Failed to delete created Product with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        } 

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<Product> Create(bool skipAddToCreateList = false, ProductCreateOptions options = null)
        {
            var obj = await _Service.CreateAsync(new Product()
            {
                Title = "Burton Custom Freestlye 151",
                Vendor = "Burton",
                BodyHtml = "<strong>Good snowboard!</strong>",
                ProductType = "Snowboard",
                Images = new List<ProductImage>
                {
                    new ProductImage
                    {
                        Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="
                    }
                },
            }, options);

            if (! skipAddToCreateList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Products()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Products()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Products()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Products)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Products()
        {
            var obj = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_Title, obj.Title);
            Assert.Equal(_BodyHtml, obj.BodyHtml);
            Assert.Equal(_ProductType, obj.ProductType);
            Assert.Equal(_Vendor, obj.Vendor);
        }

        [Fact]
        public async Task Creates_Products()
        {
            var obj = await Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_Title, obj.Title);
            Assert.Equal(_BodyHtml, obj.BodyHtml);
            Assert.Equal(_ProductType, obj.ProductType);
            Assert.Equal(_Vendor, obj.Vendor);
        }

        [Fact]
        public async Task Creates_Unpublished_Products()
        {
            var created = await Create(options: new ProductCreateOptions()
            {
                Published = false
            });

            Assert.False(created.PublishedAt.HasValue);
        }

        [Fact]
        public async Task Updates_Products()
        {
            string title = "ShopifySharp Updated Test Product";
            var original = _Created.First();
            original.Title = title;

            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(title, updated.Title);
        }

        [Fact]
        public async Task Publishes_Products()
        {
            var created = await Create(options: new ProductCreateOptions()
            {
                Published = false
            });
            var published = await _Service.PublishAsync(created.Id.Value);

            Assert.True(published.PublishedAt.HasValue);
        }

        [Fact]
        public async Task Unpublishes_Products()
        {
            var created = await Create(options: new ProductCreateOptions()
            {
                Published = true
            });
            var unpublished = await _Service.UnpublishAsync(created.Id.Value);

            Assert.False(unpublished.PublishedAt.HasValue);
        }
    }
}
