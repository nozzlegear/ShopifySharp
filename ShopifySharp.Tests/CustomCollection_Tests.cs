using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "CustomCollection")]
    public class CustomCollection_Tests : IClassFixture<CustomCollection_Tests_Fixture>
    {
        private CustomCollection_Tests_Fixture Fixture { get; }

        public CustomCollection_Tests(CustomCollection_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_CustomCollections()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_CustomCollections()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Gets_CustomCollections()
        {
            var collection = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

            Assert.NotNull(collection);
            Assert.True(collection.Id.HasValue);
            Assert.NotNull(collection.Image);
            Assert.NotEmpty(collection.Image.Src);
            Assert.Equal(Fixture.Title, collection.Title);
        }

        [Fact]
        public async Task Deletes_CustomCollections()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
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
            var collection = await Fixture.Create();

            Assert.NotNull(collection);
            Assert.True(collection.Id.HasValue);
            Assert.NotNull(collection.Image);
            Assert.NotEmpty(collection.Image.Src);
            Assert.Equal(Fixture.Title, collection.Title);
        }

        [Fact]
        public async Task Updates_CustomCollections()
        {
            string newTitle = "New Title";
            var created = await Fixture.Create();
            created.Title = newTitle;
            
            var updated = await Fixture.Service.UpdateAsync(created);

            Assert.Equal(newTitle, updated.Title);   
        }
    }

    public class CustomCollection_Tests_Fixture : IAsyncLifetime
    {
        public CustomCollectionService Service => new CustomCollectionService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<CustomCollection> Created { get; } = new List<CustomCollection>();

        public string Title => "Things";

        public async Task InitializeAsync()
        {
            // Create one collection for use with count, list, get, etc. tests.
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
            var obj = await Service.CreateAsync(new CustomCollection()
            {
                Title = Title,
                Published = false,
                Image = new CustomCollectionImage()
                {
                    Src = "http://placehold.it/250x250"
                }
            });

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}