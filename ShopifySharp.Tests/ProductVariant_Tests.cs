using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ProductVariant")]
    public class ProductVariant_Tests : IAsyncLifetime
    {
        private ProductVariantService _Service => new ProductVariantService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<ProductVariant> _Created { get; } = new List<ProductVariant>();

        private string _Option1 => "blue";
        
        private double _Price => 123.45;

        private long _ProductId { get; set; }

        public async Task InitializeAsync()
        {
            // Get a product id to use with these tests.
            _ProductId = (await new ProductService(Utils.MyShopifyUrl, Utils.AccessToken).ListAsync(new ProductFilter()
            {
                Limit = 1
            })).First().Id.Value;

            // Create one for use with count, list, get, etc. tests.
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
                        Console.WriteLine($"Failed to delete created ProductVariant with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<ProductVariant> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(_ProductId, new ProductVariant()
            {
                Option1 = _Option1,
                Price = _Price,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Variants()
        {
            var count = await _Service.CountAsync(_ProductId);

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Variants()
        {
            var list = await _Service.ListAsync(_ProductId);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Variants()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(_ProductId, created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Variants)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Variants()
        {
            var created = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal(_Price, created.Price);
            Assert.Equal(_Option1, created.Option1);
        }

        [Fact]
        public async Task Creates_Variants()
        {
            var created = await Create();

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal(_Price, created.Price);
            Assert.Equal(_Option1, created.Option1);
        }

        [Fact]
        public async Task Updates_Variants()
        {
            string option2 = "green";
            var original = _Created.First();
            original.Option2 = option2;

            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(option2, updated.Option2);
        }
    }
}
