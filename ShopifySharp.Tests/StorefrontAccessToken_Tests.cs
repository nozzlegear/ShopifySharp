using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "StorefrontAccessToken")]
    public class StorefrontAccessToken_Tests : IClassFixture<StorefrontAccessToken_Tests_Fixture>
    {
        private StorefrontAccessToken_Tests_Fixture Fixture { get; }
        
        public StorefrontAccessToken_Tests(StorefrontAccessToken_Tests_Fixture fixture)
        {
            Fixture = fixture;
        }
        
        [Fact(Skip = "Cannot run with private app, returns \"(403 Forbidden) App must be extendable to create a storefront access token\".")]
        public async Task Creates_Storefront_Access_Tokens()
        {
            var title = $"Test-Access-Token-For-ShopifySharp-{Guid.NewGuid()}";
            var createdToken = await Fixture.Service.CreateAsync(title);
            
            Assert.Equal(title, createdToken.Title);
            Assert.NotNull(createdToken.Id);
            Assert.NotEmpty(createdToken.AccessToken);
            Assert.NotEmpty(createdToken.AccessScope);
            Assert.NotNull(createdToken.CreatedAt);
        }

        [Fact(Skip = "Cannot run with private app, returns \"(403 Forbidden) App must be extendable to create a storefront access token\".")]
        public async Task Deletes_Storefront_Access_Tokens()
        {
            var title = $"Test-Access-Token-For-ShopifySharp-{Guid.NewGuid()}";
            var createdToken = await Fixture.Service.CreateAsync(title);

            await Fixture.Service.DeleteAsync(createdToken.Id.Value);
        }

        [Fact(Skip = "Cannot run with private app, returns \"(403 Forbidden) App must be extendable to create a storefront access token\".")]
        public async Task Lists_Storefront_Access_Tokens()
        {
            var title = $"Test-Access-Token-For-ShopifySharp-{Guid.NewGuid()}";
            var createdToken = await Fixture.Service.CreateAsync(title);
            var list = await Fixture.Service.ListAsync();
            
            Assert.NotEmpty(list);
            Assert.Contains(list, item => item.Title == title);
        }
    }

    public class StorefrontAccessToken_Tests_Fixture : IAsyncLifetime
    {
        public StorefrontAccessTokenService Service { get; } = new StorefrontAccessTokenService(Utils.MyShopifyUrl, Utils.AccessToken);

        public List<StorefrontAccessToken> Created { get; } = new List<StorefrontAccessToken>();

        public async Task InitializeAsync()
        {
            var policy = new LeakyBucketExecutionPolicy();
            Service.SetExecutionPolicy(policy);
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
                        Console.WriteLine($"Failed to delete created StorefrontAccessToken with id {obj.Id.Value}. {ex.Message}");
                    }
                }
            }
        }
    }
}