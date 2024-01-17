using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Multipass")]
    public class Multipass_Tests : IClassFixture<Multipass_Tests_Fixture>
    {
        private Multipass_Tests_Fixture Fixture { get; }

        public Multipass_Tests(Multipass_Tests_Fixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public void Link_Multipass()
        {
            string url = MultipassService.GetMultipassUrl(
                Fixture.Create(),
                Utils.MyShopifyUrl,
                Utils.MultipassSecret
            );

            Assert.True(!string.IsNullOrEmpty(url));
            Assert.Contains($"{Utils.MyShopifyUrl}/account/login/multipass", url);
        }
    }

    public class Multipass_Tests_Fixture : IAsyncLifetime
    {
        public Guid Guid = Guid.NewGuid();

        public MultipassRequest Create() => new MultipassRequest()
        {
            Email = Guid.NewGuid().ToString() + "@example.com",
            CreatedAt = DateTimeOffset.Now,
            FirstName = "John",
            LastName = "Doe",
            VerifiedEmail = true,
            MultipassIdentifier = Guid.ToString(),
            ReturnTo = $"{Utils.MyShopifyUrl}",
            Addresses = new List<Address>()
            {
                new Address()
                {
                Address1 = "123 4th Street",
                City = "Minneapolis",
                Province = "Minnesota",
                ProvinceCode = "MN",
                Zip = "55401",
                Phone = "555-555-5555",
                FirstName = "John",
                LastName = "Doe",
                Company = "Tomorrow Corporation",
                Country = "United States",
                CountryCode = "US",
                Default = true
                }
            }
        };

        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
