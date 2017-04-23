using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Page")]
    public class Page_Tests : IAsyncLifetime
    {
        private PageService _Service => new PageService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Page> _Created => new List<Page>();

        private string _Title => "ShopifySharp Page API Tests";

        private string _Html => "<strong>This string was created by ShopifySharp!</strong>";

        public async Task InitializeAsync()
        {
            // Create one for count, list, get, etc. orders.
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
                        Console.WriteLine($"Failed to delete created Page with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Page> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new ShopifySharp.Page()
            {
                CreatedAt = DateTime.UtcNow,
                Title = _Title,
                BodyHtml = _Html,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Pages()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Pages()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Pages()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Pages)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Pages()
        {
            var page = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(page);
            Assert.Equal(_Title, page.Title);
            Assert.Equal(_Html, page.BodyHtml);
        }

        [Fact]
        public async Task Creates_Pages()
        {
            var created = await Create();

            Assert.NotNull(created);
            Assert.Equal(_Title, created.Title);
            Assert.Equal(_Html, created.BodyHtml);
        }

        [Fact]
        public async Task Updates_Pages()
        {
            string html = "<h1>This string was updated while testing ShopifySharp!</h1>";
            var original = _Created.First();
            original.BodyHtml = html;

            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(html, updated.BodyHtml);
        }
    }
}
