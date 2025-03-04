using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Multipass")]
public class MultipassTests : IClassFixture<MultipassTestsFixture>
{
    private MultipassTestsFixture Fixture { get; }

    public MultipassTests(MultipassTestsFixture fixture)
    {
        this.Fixture = fixture;
    }

    [Fact]
    public void Link_Multipass()
    {
        string url = MultipassService.GetMultipassUrl(
            Fixture.Create(),
            Utils.MyShopifyUrl,
            Utils.AccessToken
        );

        Assert.True(!string.IsNullOrEmpty(url));
        Assert.Contains($"{Utils.MyShopifyUrl}/account/login/multipass", url);
    }
}

public class MultipassTestsFixture : IAsyncLifetime
{
    public Guid Guid = Guid.NewGuid();

    public Customer Create() => new Customer()
    {
        Email = Guid.NewGuid().ToString() + "@example.com",
        CreatedAt = DateTimeOffset.Now,
        FirstName = "John",
        LastName = "Doe",
        VerifiedEmail = true,
        MultipassIdentifier = Guid.ToString(),
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