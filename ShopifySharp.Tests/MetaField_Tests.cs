using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "MetaField")]
    public class MetaField_Tests : IClassFixture<MetaField_Tests_Fixture>
    {
        private MetaField_Tests_Fixture Fixture { get; }

        public MetaField_Tests(MetaField_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Metafields()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Counts_Metafields_On_Resources()
        {
            var count = await Fixture.Service.CountAsync(Fixture.ResourceId, Fixture.ResourceType);
            
            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Metafields()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Lists_Metafields_On_Resources()
        {
            var list = await Fixture.Service.ListAsync(Fixture.ResourceId, Fixture.ResourceType);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Metafields()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
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
            var created = await Fixture.Create();
            
            Assert.NotNull(created);
            Assert.Equal(Fixture.Namespace, created.Namespace);
            Assert.Equal(Fixture.Description, created.Description);
            EmptyAssert.NotNullOrEmpty(created.Key);
            Assert.NotNull(created.Value);
        }

        [Fact]
        public async Task Creates_Metafields_On_Resources()
        {
            var created = await Fixture.Create(Fixture.ResourceId, Fixture.ResourceType);

            Assert.NotNull(created);
            Assert.Equal(Fixture.Namespace, created.Namespace);
            Assert.Equal(Fixture.Description, created.Description);
            EmptyAssert.NotNullOrEmpty(created.Key);
            Assert.NotNull(created.Value);
            Assert.True(new string[] { Fixture.ResourceType, Fixture.ResourceType.Substring(0, Fixture.ResourceType.Length - 1) }.Contains(created.OwnerResource));
            Assert.Equal(Fixture.ResourceId, created.OwnerId);
        }

        [Fact]
        public async Task Updates_Metafields()
        {
            string value = "10";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Value = value;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            Assert.Equal(value, updated.Value.ToString());
        }

        [Fact]
        public async Task Updates_Metafields_On_Resources()
        {
            string value = "10";
            var created = await Fixture.Create(Fixture.ResourceId, Fixture.ResourceType);
            long id = created.Id.Value;

            created.Value = value;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            Assert.Equal(value, updated.Value.ToString());
        }
    }

    public class MetaField_Tests_Fixture : IAsyncLifetime
    {
        public MetaFieldService Service => new MetaFieldService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<ShopifySharp.MetaField> Created { get; } = new List<ShopifySharp.MetaField>();

        public string Namespace => "testing";

        public string Description => "This is a test meta field. It is an integer value.";

        public string ResourceType => "products";

        public long ResourceId { get; set; }

        public async Task InitializeAsync()
        {
            // Get a product to add metafields to.
            var products = await new ProductService(Utils.MyShopifyUrl, Utils.AccessToken).ListAsync();
            ResourceId = products.First().Id.Value;
            
            // Create a metafield for use in count, list, get, etc. tests.
            await Create();
            await Create(ResourceId, ResourceType);
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
                        Console.WriteLine($"Failed to delete created MetaField with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<MetaField> Create(bool skipAddToCreatedList = false)
        {
            var obj = await Service.CreateAsync(new MetaField()
            {
                Namespace = Namespace,
                Key = Guid.NewGuid().ToString().Substring(0, 25),
                Value = "5",
                ValueType = "integer",
                Description = Description,
            });

            if (! skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<MetaField> Create(long targetId, string resourceType, bool skipAddToCreatedList = false)
        {
            var obj = await Service.CreateAsync(new MetaField()
            {
                Namespace = Namespace,
                Key = Guid.NewGuid().ToString().Substring(0, 25),
                Value = "5",
                ValueType = "integer",
                Description = Description,
            }, targetId, resourceType);

            if (! skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}
