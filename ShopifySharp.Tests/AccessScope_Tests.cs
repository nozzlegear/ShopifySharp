using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Access scope")]
    public class AccessScope_Tests : IClassFixture<AccessScope_Tests_Fixture>
    {
        private AccessScope_Tests_Fixture Fixture { get; }

        public AccessScope_Tests(AccessScope_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public async Task List()
        {
            var scopes = await Fixture.Service.ListAsync();
            Assert.True(scopes.Count() > 0);
        }
    }

    public class AccessScope_Tests_Fixture : IAsyncLifetime
    {
        public AccessScopeService Service { get; } = new AccessScopeService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Task InitializeAsync()
        {
            Service.SetExecutionPolicy(new SmartRetryExecutionPolicy());

            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
