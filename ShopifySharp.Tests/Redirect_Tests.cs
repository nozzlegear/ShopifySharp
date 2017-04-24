using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Redirect")]
    public class Redirect_Tests : IAsyncLifetime
    {
        private RedirectService _Service => new RedirectService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Redirect> _Created => new List<Redirect>();

        private string _Target => "https://www.example.com/";

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
                        Console.WriteLine($"Failed to delete created Redirect with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<Redirect> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new Redirect()
            {
                Path = Guid.NewGuid().ToString(),
                Target = _Target,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Redirects()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Redirects()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Redirects()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Redirects)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Redirects()
        {
            var obj = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_Target, obj.Target);
            Assert.NotEmpty(obj.Path);
        }

        [Fact]
        public async Task Creates_Redirects()
        {
            var created = await Create();

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal(_Target, created.Target);
            Assert.NotEmpty(created.Path);
        }

        [Fact]
        public async Task Updates_Redirects()
        {
            string newVal = "https://example.com/updated";
            var original = _Created.First();
            original.Target = newVal;
            
            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(newVal, updated.Target);   
        }
    }
}