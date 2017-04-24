using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ProductImage")]
    public class ProductImage_Tests : IAsyncLifetime
    {
        private string _ImageFileName => "image-filename.jpg";

        private ProductService _ProductService => new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

        private ProductImageService _Service => new ProductImageService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<ProductImage> _Created { get; } = new List<ProductImage>();

        private long _ProductId { get; set; }

        public async Task InitializeAsync()
        {
            // Get a product to use as the parent for all images.
            _ProductId = (await _ProductService.ListAsync(new ProductFilter()
            {
                Limit = 1
            })).First().Id.Value;

            // Create one for count, list, get, etc. orders.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in _Created)
            {
                try
                {
                    await _Service.DeleteAsync(_ProductId, obj.Id.Value);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created Page with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<ProductImage> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(_ProductId, new ProductImage()
            {
                Filename = _ImageFileName,
                Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_ProductImages()
        {
            var count = await _Service.CountAsync(_ProductId);

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_ProductImages()
        {
            var list = await _Service.ListAsync(_ProductId);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_ProductImages()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(_ProductId, created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_ProductImages)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_ProductImages()
        {
            var image = await _Service.GetAsync(_ProductId, _Created.First().Id.Value);

            Assert.NotNull(image);
            Assert.True(image.Id.HasValue);
            Assert.Equal(_ProductId, image.ProductId);
            Assert.Equal(_ImageFileName, image.Filename);
        }

        [Fact]
        public async Task Creates_ProductImages()
        {
            var created = await Create();

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal(_ProductId, created.ProductId);
            Assert.Equal(_ImageFileName, created.Filename);
        }

        [Fact]
        public async Task Updates_ProductImages()
        {
            var original = _Created.First();
            original.Position += 1;

            int position = original.Position;
            var updated = await _Service.UpdateAsync(original.ProductId, original);

            Assert.Equal(position, updated.Position);
        }
    }
}
