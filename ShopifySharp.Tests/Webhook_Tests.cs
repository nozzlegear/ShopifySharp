using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Webhook")]
    public class Webhook_Tests : IClassFixture<Webhook_Tests_Fixture>
    {
        private Webhook_Tests_Fixture Fixture { get; }

        public Webhook_Tests(Webhook_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Webhooks()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Webhooks()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Webhooks()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
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
            var obj = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.Format, obj.Format);
            Assert.StartsWith(Fixture.UrlPrefix, obj.Address);
        }

        [Fact]
        public async Task Creates_Webhooks()
        {
            var obj = await Fixture.Create();

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.Format, obj.Format);
            Assert.StartsWith(Fixture.UrlPrefix, obj.Address);
        }

        [Fact]
        public async Task Updates_Webhooks()
        {
            string newValue = "https://requestb.in/" + Guid.NewGuid();
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Address = newValue;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(newValue, updated.Address);
        }
    }

    public class Webhook_Tests_Fixture : IAsyncLifetime
    {
        public WebhookService Service { get; } = new WebhookService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Webhook> Created { get; } = new List<Webhook>();

        public string UrlPrefix => "https://requestb.in/";

        public string Format => "json";

        public async Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

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
                        Console.WriteLine($"Failed to delete created Webhook with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Webhook> Create(bool skipAddToCreatedList = false, string topic = "orders/create")
        {
            var obj = await Service.CreateAsync(new Webhook()
            {
                Address = UrlPrefix + Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                Fields = new string[] { "field1", "field2" },
                Format = Format,
                Topic = topic,
            });

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}