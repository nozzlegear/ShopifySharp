using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ScriptTag")]
    public class ScriptTag_Tests : IAsyncLifetime
    {
        private ScriptTagService _Service => new ScriptTagService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<ScriptTag> _Created => new List<ScriptTag>();

        private string _Event => "onload";

        private string _Src => "https://unpkg.com/davenport@2.1.0/bin/browser.js";

        private string _Scope => "online_store";

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
                        Console.WriteLine($"Failed to delete created ScriptTag with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<ScriptTag> Create(bool skipAddToCreatedList = false)
        {
            var obj = await _Service.CreateAsync(new ScriptTag()
            {
                Event = _Event,
                Src = _Src,
                DisplayScope = _Scope,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_ScriptTags()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_ScriptTags()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_ScriptTags()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_ScriptTags)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_ScriptTags()
        {
            var obj = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_Src, obj.Src);
            Assert.Equal(_Event, obj.Event);
            Assert.Equal(_Scope, obj.DisplayScope);
        }

        [Fact]
        public async Task Creates_ScriptTags()
        {
            var obj = await Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_Src, obj.Src);
            Assert.Equal(_Event, obj.Event);
            Assert.Equal(_Scope, obj.DisplayScope);
        }

        [Fact]
        public async Task Updates_ScriptTags()
        {
            string newValue = "all";
            var original = _Created.First();
            original.DisplayScope = newValue;
            
            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(newValue, updated.DisplayScope);   
        }
    }
}