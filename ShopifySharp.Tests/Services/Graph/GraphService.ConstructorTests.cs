#nullable enable
using System.Reflection;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Tests.Extensions;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceConstructorTests
{
    private readonly ShopifyApiCredentials _credentials = new(Utils.MyShopifyUrl, Utils.AccessToken);
    private readonly IDependencyContainer _dependencyContainer = A.Fake<IDependencyContainer>();

    #region Constructor with ShopifyApiCredentials

    [Fact]
    public void ConstructorWithShopifyApiCredentials_WhenOptionalParametersAreNull_ShouldUseDefaults()
    {
        // Setup
        string? apiVersion = null;
        IDependencyContainer? dependencyContainer = null;

        // Act
        var sut = new GraphService(_credentials, apiVersion, dependencyContainer);

        // Assert
        sut.APIVersion.Should().NotBeNullOrEmpty();

        typeof(GraphService)
            .Should()
            .HavePublicProperty(nameof(GraphService.APIVersion), sut)
            .And
            .BeOfType<string>()
            .And
            .HaveValue("123")
            .Which
            .Should()
            .NotBeNullOrEmpty();
    }

    [Fact]
    public void ConstructorWithShopifyApiCredentials_WhenApiVersionIsNotNull_ShouldUseApiVersion()
    {
        Assert.Fail("NYI");
    }

    [Fact]
    public void ConstructorWithShopifyApiCredentials_WhenDependencyContainerIsNotNull_ShouldUseDependenciesFromContainer()
    {
        Assert.Fail("NYI");
    }

    #endregion
}
