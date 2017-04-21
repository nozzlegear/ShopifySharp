using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "CustomCollection")]
    public class CustomCollection_Tests : IAsyncLifetime
    {
        private CustomCollectionService _Service => new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<CustomCollection> _Created => new List<CustomCollection>();

        private string _Title => "Things";

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
                        Console.WriteLine($"Failed to delete created CustomCollection with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<CustomCollection> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new CustomCollection()
            {
                Title = _Title,
                Published = false,
                Image = new CustomCollectionImage()
                {
                    Src = "http://placehold.it/250x250"
                }
            });

            if (!skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_CustomCollections()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_CustomCollections()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Gets_CustomCollections()
        {
            var collection = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(collection);
            Assert.True(collection.Id.HasValue);
            Assert.NotNull(collection.Image);
            Assert.NotEmpty(collection.Image.Src);
            Assert.Equal(_Title, collection.Title);
        }

        [Fact]
        public async Task Deletes_CustomCollections()
        {
            var created = await Create();
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_CustomCollections)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }


        [Fact]
        public async Task Creates_CustomCollections()
        {
            var collection = await Create();

            Assert.NotNull(collection);
            Assert.True(collection.Id.HasValue);
            Assert.NotNull(collection.Image);
            Assert.NotEmpty(collection.Image.Src);
            Assert.Equal(_Title, collection.Title);
        }

        [Fact]
        public async Task Updates_CustomCollections()
        {
            string newTitle = "New Title";
            var created = await Create();
            created.Title = newTitle;
            
            var updated = await _Service.UpdateAsync(created);

            Assert.Equal(newTitle, updated.Title);   
        }
    }
}
