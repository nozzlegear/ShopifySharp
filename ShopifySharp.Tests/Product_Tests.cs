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
                        Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="
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
