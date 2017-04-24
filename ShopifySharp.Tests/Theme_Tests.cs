using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Theme")]
    public class Theme_Tests : IAsyncLifetime
    {
        private ThemeService _Service => new ThemeService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Theme> _Created { get; } = new List<Theme>();

        /// <summary>
        /// A URL pointing to a zipped up Shopify theme.
        /// </summary>
        private string _ZipUrl => "https://ironstorage.blob.core.windows.net/public-downloads/ShopifySharp/shopify_test_theme_for_shopifysharp.zip";

        private string _NamePrefix => "ShopifySharp Test Theme ";

        private string _Role => "unpublished";

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
                        Console.WriteLine($"Failed to delete created Theme with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<Theme> Create(bool skipAddToCreatedList = false, bool fromZipUrl = false)
        {
            var theme = new Theme()
            {
                Name = _NamePrefix + Guid.NewGuid(),
                Role = _Role,   
            };
            var obj = fromZipUrl ? await _Service.CreateAsync(theme, _ZipUrl) : await _Service.CreateAsync(theme);

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Lists_Themes()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Themes()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Themes)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Themes()
        {
            var obj = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.StartsWith(_NamePrefix, obj.Name);
            Assert.Equal(_Role, obj.Role);
        }

        [Fact]
        public async Task Creates_Themes()
        {
            var obj = await Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.StartsWith(_NamePrefix, obj.Name);
            Assert.Equal(_Role, obj.Role);
        }

        [Fact]
        public async Task Creates_Themes_From_Zip_Files()
        {
            var obj = await Create(fromZipUrl: true);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.StartsWith(_NamePrefix, obj.Name);
            Assert.Equal(_Role, obj.Role);
        }

        [Fact]
        public async Task Updates_Themes()
        {
            string newValue = "ShopifySharp Updated Theme " + Guid.NewGuid();
            var original = _Created.First();
            original.Name = newValue;
            
            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(newValue, updated.Name);
        }
    }
}