using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Webhook")]
    public class Webhook_Tests : IAsyncLifetime
    {
        private WebhookService _Service => new WebhookService(Utils.MyShopifyUrl, Utils.AccessToken);

        private List<Webhook> _Created { get; } = new List<Webhook>();

        private string _UrlPrefix => "https://requestb.in/";

        private string _Format => "json";

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
                        Console.WriteLine($"Failed to delete created Webhook with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        private async Task<Webhook> Create(bool skipAddToCreatedList = false, string topic = "orders/create")
        {
            var obj = await _Service.CreateAsync(new Webhook()
            {
                Address = _UrlPrefix + Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                Fields = new string[] { "field1", "field2" },
                Format = _Format,
                Topic = topic,
            });

            if (! skipAddToCreatedList)
            {
                _Created.Add(obj);
            }

            return obj;
        }

        [Fact]
        public async Task Counts_Webhooks()
        {
            var count = await _Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Webhooks()
        {
            var list = await _Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Webhooks()
        {
            var created = await Create(true);
            bool threw = false;

            try
            {
                await _Service.DeleteAsync(created.Id.Value);
            }
            catch (ShopifyException ex)
            {
                Console.WriteLine($"{nameof(Deletes_Webhooks)} failed. {ex.Message}");

                threw = true;
            }

            Assert.False(threw);
        }

        [Fact]
        public async Task Gets_Webhooks()
        {
            var obj = await _Service.GetAsync(_Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_Format, obj.Format);
            Assert.StartsWith(_UrlPrefix, obj.Address);
        }

        [Fact]
        public async Task Creates_Webhooks()
        {
            var obj = await Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(_Format, obj.Format);
            Assert.StartsWith(_UrlPrefix, obj.Address);
        }

        [Fact]
        public async Task Updates_Webhooks()
        {
            string newValue = "https://requestb.in/" + Guid.NewGuid();
            var original = _Created.First();
            original.Address = newValue;
            
            var updated = await _Service.UpdateAsync(original);

            Assert.Equal(newValue, updated.Address);
        }
    }
}