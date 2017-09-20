using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "User")]
    public class User_Tests : IClassFixture<User_Tests_Fixture>
    {
        private User_Tests_Fixture Fixture { get; }

        public User_Tests(User_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }


        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Lists_Users()
        {
            var list = await Fixture.Service.ListAsync();

            Assert.True(list.Any());
        }


        [Fact(Skip = "Cannot run without a Shopify Plus account.")]
        public async Task Gets_Users()
        {
            // Find an id 
            var list = await Fixture.Service.ListAsync();
            var user = await Fixture.Service.GetAsync(list.First().Id.Value);

            Assert.NotNull(user);
            Assert.Equal(user.Id, list.First().Id);
        }
    }

    public class User_Tests_Fixture : IAsyncLifetime
    {
        public UserService Service => new UserService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Task InitializeAsync() => Task.CompletedTask;

        public Task DisposeAsync() => Task.CompletedTask;
    }
}
