using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ShopifySharp.Filters;
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
            string url = Fixture.Service.GetMultipassUrl(Fixture.Create());

            Assert.True(!string.IsNullOrEmpty(url));
        }
    }

    public class Multipass_Tests_Fixture : IAsyncLifetime
    {
        public MultipassService Service { get; } = new MultipassService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Guid Guid = Guid.NewGuid();

        public Customer Create() => new Customer()
        {
            Email = Guid.NewGuid().ToString() + "@example.com",
            FirstName = "John",
            LastName = "Doe",
            VerifiedEmail = true,
            MultipassIdentifier = Guid.ToString(),
            AcceptsMarketing = true,
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
            return null;
        }

        public Task DisposeAsync()
        {
            //not sure how to find created user;
            return null;
        }
    }
}
