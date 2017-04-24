using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "SmartCollection")]
    public class SmartCollection_Tests : IAsyncLifetime
    {
        private SmartCollectionService _Service => new SmartCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<SmartCollection> _Created => new List<SmartCollection>();

        private string _BodyHtml => "<h1>Hello world!</h1>";

        private string _Handle => "ShopifySharp-Handle";

        private string _Title => "ShopifySharp Test Smart Collection";

        public async Task InitializeAsync()
        {
            // Create one collection for use with count, list, get, etc. tests.
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
                        Console.WriteLine($"Failed to delete created SmartCollection with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<SmartCollection> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new SmartCollection()
            {
                BodyHtml =  _BodyHtml,
                Handle = _Handle,
                Title = _Title,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_SmartCollections()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_SmartCollections()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_SmartCollections()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_SmartCollections)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_SmartCollections()
        {
            var obj = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_BodyHtml, obj.BodyHtml);
            Assert.Equal(_Title, obj.Title);
            Assert.Equal(_Handle, obj.Handle);
        }

        [Fact]
        public async Task Creates_SmartCollections()
        {
            var obj = await Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_BodyHtml, obj.BodyHtml);
            Assert.Equal(_Title, obj.Title);
            Assert.Equal(_Handle, obj.Handle);
        }

        [Fact]
        public async Task Updates_SmartCollections()
        {
            string newValue = "New Title";
            var original = _Created.First();
            original.Title = newValue;
            
            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(newValue, updated.Title);   
        }
    }
}