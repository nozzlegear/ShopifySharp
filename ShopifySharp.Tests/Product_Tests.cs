using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Product")]
    public class Product_Tests : IClassFixture<Product_Tests_Fixture>
    {
        private Product_Tests_Fixture Fixture { get; }

        public Product_Tests(Product_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Products()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Products_NoFilter()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Items.Any());
            Assert.NotNull(list.LinkHeader.NextLink);
            Assert.NotNull(list.LinkHeader.NextLink.PageInfo);
            Assert.NotNull(list.LinkHeader.NextLink.Url);
        }

        [Fact]
        public async Task Lists_Products_ComparePagingByCursorAndBySinceId()
        {
            var list = await Fixture.Service.ListAsync(new ProductListFilter
            {
                SinceId = 0,
                Limit = 2
            });
            Assert.True(list.Items.Count() == 2);
            Assert.NotNull(list.LinkHeader.NextLink);
            Assert.NotNull(list.LinkHeader.NextLink.PageInfo);
            Assert.NotNull(list.LinkHeader.NextLink.Url);

            var nextPageViaCursor = await Fixture.Service.ListAsync(list.GetNextPageFilter(2));
            Assert.True(list.Items.Count() == 2);
            Assert.NotNull(list.LinkHeader.NextLink);
            Assert.NotNull(list.LinkHeader.NextLink.PageInfo);
            Assert.NotNull(list.LinkHeader.NextLink.Url);

            var nextPageViaSinceId = await Fixture.Service.ListAsync(new ProductListFilter
            {
                SinceId = list.Items.Last().Id.Value,
                Limit = 2
            });
            Assert.True(list.Items.Count() == 2);
            Assert.NotNull(list.LinkHeader.NextLink);
            Assert.NotNull(list.LinkHeader.NextLink.PageInfo);
            Assert.NotNull(list.LinkHeader.NextLink.Url);

            Assert.True(Enumerable.SequenceEqual(nextPageViaCursor.Items.Select(i => i.Id.Value),
                                                 nextPageViaSinceId.Items.Select(i => i.Id.Value)));
        }

        [Fact]
        public async Task Lists_Products_PageAll()
        {
            var svc = Fixture.Service;
            var list = await svc.ListAsync(new ProductListFilter { Limit = 5 });

            while (true)
            {
                Assert.True(list.Items.Any());
                list = await svc.ListAsync(list.GetNextPageFilter());
                if (!list.HasNextPage)
                    break;
            }
        }

        [Fact]
        public async Task Deletes_Products()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
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
            var obj = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.Title, obj.Title);
            Assert.Equal(Fixture.BodyHtml, obj.BodyHtml);
            Assert.Equal(Fixture.ProductType, obj.ProductType);
            Assert.Equal(Fixture.Vendor, obj.Vendor);
        }

        [Fact]
        public async Task Creates_Products()
        {
            var obj = await Fixture.Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.Title, obj.Title);
            Assert.Equal(Fixture.BodyHtml, obj.BodyHtml);
            Assert.Equal(Fixture.ProductType, obj.ProductType);
            Assert.Equal(Fixture.Vendor, obj.Vendor);
        }

        [Fact]
        public async Task Creates_Unpublished_Products()
        {
            var created = await Fixture.Create(options: new ProductCreateOptions()
            {
                Published = false
            });

            Assert.False(created.PublishedAt.HasValue);
        }

        [Fact]
        public async Task Updates_Products()
        {
            string title = "ShopifySharp Updated Test Product";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Title = title;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(title, updated.Title);
        }

        [Fact]
        public async Task Updates_Products_UsingUpdateBuilder()
        {
            string title = "ShopifySharp Updated Test Field Product";
            string productType = "Test Field Product";

            var created = await Fixture.Create();

            var builder = new UpdateBuilder<Product>()
                .Update(prod => prod.Title, title)
                .Update(prod => prod.ProductType, productType);

            var updated = await Fixture.Service.UpdateAsync(created.Id.Value, builder);

            Assert.Equal(title, updated.Title);
            Assert.NotEqual(created.Title, updated.Title);
            Assert.Equal(productType, updated.ProductType);
            Assert.NotEqual(created.ProductType, updated.ProductType);
            Assert.NotNull(updated.BodyHtml);
            Assert.NotEmpty(updated.BodyHtml);
            Assert.Null(updated.TemplateSuffix);
        }

        [Fact]
        public async Task Publishes_Products()
        {
            var created = await Fixture.Create(options: new ProductCreateOptions()
            {
                Published = false
            });
            var published = await Fixture.Service.PublishAsync(created.Id.Value);

            Assert.True(published.PublishedAt.HasValue);
        }

        [Fact]
        public async Task Unpublishes_Products()
        {
            var created = await Fixture.Create(options: new ProductCreateOptions()
            {
                Published = true
            });
            var unpublished = await Fixture.Service.UnpublishAsync(created.Id.Value);

            Assert.False(unpublished.PublishedAt.HasValue);
        }
    }

    public class Product_Tests_Fixture : IAsyncLifetime
    {
        public ProductService Service { get; } = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Product> Created { get; } = new List<Product>();

        public string Title => "ShopifySharp Test Product";

        public string Vendor = "Auntie Dot";

        public string BodyHtml => "<strong>This product was created while testing ShopifySharp!</strong>";

        public string ProductType => "Foobars";

        public async Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            // Create one for count, list, get, etc. orders.
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
                        Console.WriteLine($"Failed to delete created Product with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Product> Create(bool skipAddToCreateList = false, ProductCreateOptions options = null)
        {
            var obj = await Service.CreateAsync(new Product()
            {
                Title = Title,
                Vendor = Vendor,
                BodyHtml = BodyHtml,
                ProductType = ProductType,
                Handle = Guid.NewGuid().ToString(),
                Images = new List<ProductImage>
                {
                    new ProductImage
                    {
                        Alt = "Image for ShopifySharp Test Product",
                        Attachment = "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"
                    }
                },
            }, options);

            if (!skipAddToCreateList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}