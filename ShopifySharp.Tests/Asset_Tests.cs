using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Asset")]
    public class Asset_Tests : IAsyncLifetime
    {
        AssetService _Service => new AssetService(Utils.MyShopifyUrl, Utils.AccessToken);

        List<Asset> _Created => new List<Asset>();

        string _AssetValue => "<h1>Hello world!</h1>";

        long _ThemeId { get; set; }

        public async Task InitializeAsync()
        {
            var themeService = new ThemeService(Utils.MyShopifyUrl, Utils.AccessToken);  
            var themes = await themeService.ListAsync();  

            _ThemeId = themes.First().Id.Value;
        }

        public async Task DisposeAsync()
        {
            foreach (var asset in _Created)
            {
                try
                {
                    await _Service.DeleteAsync(_ThemeId, asset.Key);
                }
                catch (ShopifyException ex)
                {
                    if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Failed to delete created Asset with key {asset.Key}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates the object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Asset> Create(string key, bool skipAddToCreatedList = false)
        {
            var asset = await _Service.CreateOrUpdateAsync(_ThemeId, new Asset()
            {
                ContentType = "text/x-liquid",
                Value = _AssetValue,
                Key = key
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(asset);
            }

            return asset;
        }

        [Fact]
        public async Task Creates_Assets()
        {
            string key = "templates/test.liquid";
            var asset = await Create(key);

            Assert.NotNull(asset);
            Assert.Equal(asset.Key, key);
            Assert.Equal(asset.Value, _AssetValue);
            Assert.Equal(asset.ThemeId, _ThemeId);
        }

        [Fact]
        public async Task Updates_Assets()
        {
            string key = "templates/update-test.liquid";
            string newValue = "<h1>Hello, world! I've been updated!</h1>";
            var asset = await Create(key);
            
            asset.Value = newValue;
            asset = await _Service.CreateOrUpdateAsync(_ThemeId, asset);

            Assert.Equal(asset.Value, newValue);
        }

        [Fact]
        public async Task Gets_Assets()
        {
            string key = _Created.First().Key;
            var asset = await _Service.GetAsync(_ThemeId, key);

            Assert.NotNull(asset);
            Assert.Equal(asset.Key, key);
            Assert.Equal(asset.ThemeId, _ThemeId);
        }

        [Fact]
        public async Task Copies_Assets()
        {
            string key = "templates/copy-test.liquid";
            var original = await Create("templates/copy-original-test.liquid");
            var asset = await _Service.CreateOrUpdateAsync(_ThemeId, new Asset()
            {
                Key = key,
                SourceKey = original.Key,
            });

            Assert.NotNull(asset);
            Assert.Equal(asset.Key, key);
            Assert.Equal(asset.Value, original.Value);
            Assert.Equal(asset.ContentType, original.ContentType);
            Assert.Equal(asset.ThemeId, _ThemeId);
        }

        [Fact]
        public async Task Lists_Assets()
        {
            var list = await _Service.ListAsync(_ThemeId);

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Assets()
        {
            bool threw = false;
            string key = "templates/delete-test.liquid";
            var created = await Create(key, true);

            try
            {
                await _Service.DeleteAsync(_ThemeId, key);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Assets)} threw exception. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }
    }
}
