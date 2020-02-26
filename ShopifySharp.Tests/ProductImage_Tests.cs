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
    public class ProductImage_Tests : IClassFixture<ProductImage_Tests_Fixture>
    {
        private ProductImage_Tests_Fixture Fixture { get; }

        public ProductImage_Tests(ProductImage_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_ProductImages()
        {
            var count = await Fixture.Service.CountAsync(Fixture.ProductId);

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_ProductImages()
        {
            var list = await Fixture.Service.ListAsync(Fixture.ProductId);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_ProductImages()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(Fixture.ProductId, created.Id.Value);
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
            var image = await Fixture.Service.GetAsync(Fixture.ProductId, Fixture.Created.First().Id.Value);

            Assert.NotNull(image);
            Assert.True(image.Id.HasValue);
            Assert.Equal(Fixture.ProductId, image.ProductId);
        }

        [Fact]
        public async Task Creates_ProductImages()
        {
            var created = await Fixture.Create();

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal(Fixture.ProductId, created.ProductId);
        }

        [Fact]
        public async Task Updates_ProductImages()
        {
            var created = await Fixture.Create();
            var newAlt = $"ShopifySharp test {Guid.NewGuid()}";
            long id = created.Id.Value;

            created.Alt = newAlt;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(created.ProductId.Value, id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(newAlt, updated.Alt);
        }
    }

    public class ProductImage_Tests_Fixture : IAsyncLifetime
    {
        public string ImageFileName => "image-filename.jpg";

        public ProductService ProductService { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

        public ProductImageService Service { get; } = new ProductImageService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<ProductImage> Created { get; } = new List<ProductImage>();

        public long ProductId { get; set; }

        public async Task InitializeAsync()
        {
            var policy = new SmartRetryExecutionPolicy();

            Service.SetExecutionPolicy(policy);
            ProductService.SetExecutionPolicy(policy);

            // Get a product to use as the parent for all images.
            ProductId = (await ProductService.ListAsync(new ProductListFilter()
            {
                Limit = 1
            })).Items.First().Id.Value;

            // Create one for count, list, get, etc. orders.
            await Create();
        }

        public async Task DisposeAsync()
        {
            foreach (var obj in Created)
            {
                try
                {
                    await Service.DeleteAsync(ProductId, obj.Id.Value);
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
        public async Task<ProductImage> Create(bool skipAddToCreatedList = false)
        {
            var obj = await Service.CreateAsync(ProductId, new ProductImage()
            {
                Filename = ImageFileName,
                Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==\n"
            });

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
