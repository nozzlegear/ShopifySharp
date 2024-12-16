using System;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Factories;
using Xunit;

namespace ShopifySharp.Tests.Factories;

[TestSubject(typeof(OrderServiceFactory))]
[Trait("Category", "Factories")]
public class OrderServiceFactoryTest
{
    private const string ShopDomain = "some-shop-domain";
    private const string AccessToken = "some-access-token";

    private readonly IServiceProvider _serviceProvider = A.Fake<IServiceProvider>();
    private readonly OrderServiceFactory _sut;

    public OrderServiceFactoryTest()
    {
        _sut = new OrderServiceFactory(_serviceProvider);
    }

    [Fact]
    public void Create_ReturnsTheService()
    {
        // Act
        var service = _sut.Create(ShopDomain, AccessToken);

        // Assert
        service.Should().NotBeNull();
        service.Should().BeOfType<OrderService>().And.BeAssignableTo<IOrderService>();
    }

    [Fact]
    public void Create_WhenGivenShopifyPartnerApiCredentials_ReturnsTheService()
    {
        // Setup
        var credentials = new ShopifyApiCredentials(ShopDomain, AccessToken);

        // Act
        var service = _sut.Create(credentials);

        // Assert
        service.Should().NotBeNull();
        service.Should().BeOfType<OrderService>().And.BeAssignableTo<IOrderService>();
    }
}
