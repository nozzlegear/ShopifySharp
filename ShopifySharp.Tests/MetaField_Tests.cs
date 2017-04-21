using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "MetaField")]
    public class MetaField_Tests : IAsyncLifetime
    {
        private MetaFieldService _Service => new MetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<ShopifySharp.MetaField> _Created => new List<ShopifySharp.MetaField>();

        private string _Namespace => "testing";

        private string _Description => "This is a test meta field. It is an integer value.";

        private string _ResourceType => "products";

        private long _ResourceId { get; set; }

        public async Task InitializeAsync()
        {
            // Get a product to add metafields to.
            var products = await new ProductService(Utils.MyShopifyUrl, Utils.AccessToken).ListAsync();
            _ResourceId = products.First().Id.Value;
            
            // Create a metafield for use in count, list, get, etc. tests.
            await Create();
            await Create(_ResourceId, _ResourceType);
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
                        Console.WriteLine($"Failed to delete created MetaField with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<MetaField> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new MetaField()
            {
                Namespace = _Namespace,
                Key = Guid.NewGuid().ToString(),
                Value = "5",
                ValueType = "integer",
                Description = _Description,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<MetaField> Create(long targetId, string resourceType, bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new MetaField()
            {
                Namespace = _Namespace,
                Key = Guid.NewGuid().ToString(),
                Value = "5",
                ValueType = "integer",
                Description = _Description,
            }, targetId, resourceType);

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Metafields()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Counts_Metafields_On_Resources()
        {
            var count = await _Service.CountAsync(_ResourceId, _ResourceType);
            
            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Metafields()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Lists_Metafields_On_Resources()
        {
            var list = await _Service.ListAsync(_ResourceId, _ResourceType);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Metafields()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Metafields)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Creates_Metafields()
        {
            var created = await Create();
            
            Assert.NotNull(created);
            Assert.Equal(_Namespace, created.Namespace);
            Assert.Equal(_Description, created.Description);
            Assert.NotEmpty(created.Key);
            Assert.NotNull(created.Value);
        }

        [Fact]
        public async Task Creates_Metafields_On_Resources()
        {
            var created = await Create(_ResourceId, _ResourceType);

            Assert.NotNull(created);
            Assert.Equal(_Namespace, created.Namespace);
            Assert.Equal(_Description, created.Description);
            Assert.NotEmpty(created.Key);
            Assert.NotNull(created.Value);
            Assert.Equal(_ResourceType, created.OwnerResource);
            Assert.Equal(_ResourceId, created.OwnerId);
        }

        [Fact]
        public async Task Updates_Metafields()
        {
            string value = "10";
            var created = await Create();
            created.Value = value;

            var updated = await _Service.UpdateAsync(created);

            Assert.Equal(value, updated.Value);
        }

        [Fact]
        public async Task Updates_Metafields_On_Resources()
        {
            string value = "10";
            var created = await Create(_ResourceId, _ResourceType);
            created.Value = value;

            var updated = await _Service.UpdateAsync(created);

            Assert.Equal(value, updated.Value);
        }
    }
}
