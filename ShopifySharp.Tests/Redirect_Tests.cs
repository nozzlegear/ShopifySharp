using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Redirect")]
    public class Redirect_Tests : IClassFixture<Redirect_Tests_Fixture>
    {
        private Redirect_Tests_Fixture Fixture { get; }

        public Redirect_Tests(Redirect_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task Counts_Redirects()
        {
            var count = await Fixture.Service.CountAsync();

            Assert.True(count > 0);
        }

        [Fact]
        public async Task Lists_Redirects()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Items.Count() > 0);
        }

        [Fact]
        public async Task Deletes_Redirects()
        {
            var created = await Fixture.Create(true);
            bool threw = false;

            try
            {
                await Fixture.Service.DeleteAsync(created.Id.Value);
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
            var created = await Fixture.Create();
            var obj = await Fixture.Service.GetAsync(created.Id.Value);

            Assert.NotNull(obj);
            Assert.True(obj.Id.HasValue);
            Assert.Equal(Fixture.Target, obj.Target);
            EmptyAssert.NotNullOrEmpty(obj.Path);
        }

        [Fact]
        public async Task Creates_Redirects()
        {
            var created = await Fixture.Create();

            Assert.NotNull(created);
            Assert.True(created.Id.HasValue);
            Assert.Equal(Fixture.Target, created.Target);
            EmptyAssert.NotNullOrEmpty(created.Path);
        }

        [Fact]
        public async Task Updates_Redirects()
        {
            string newVal = "https://example.com/updated";
            var created = await Fixture.Create();
            long id = created.Id.Value;

            created.Target = newVal;
            created.Id = null;

            var updated = await Fixture.Service.UpdateAsync(id, created);

            // Reset the id so the Fixture can properly delete this object.
            created.Id = id;

            Assert.Equal(newVal, updated.Target);
        }
    }

    public class Redirect_Tests_Fixture : IAsyncLifetime
    {
        public RedirectService Service { get; } = new RedirectService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<Redirect> Created { get; } = new List<Redirect>();

        public string Target => "https://www.example.com/";

        public async Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

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
                        Console.WriteLine($"Failed to delete created Redirect with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Convenience function for running tests. Creates an object and automatically adds it to the queue for deleting after tests finish.
        /// </summary>
        public async Task<Redirect> Create(bool skipAddToCreatedList = false)
        {
            var obj = await Service.CreateAsync(new Redirect()
            {
                Path = Guid.NewGuid().ToString(),
                Target = Target,
            });

            if (!skipAddToCreatedList)
            {
                Created.Add(obj);
            }

            return obj;
        }
    }
}