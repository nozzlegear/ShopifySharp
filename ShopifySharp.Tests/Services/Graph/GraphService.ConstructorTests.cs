#nullable enable
using System.Text.Json;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Tests.Extensions;
using ShopifySharp.Utilities;
using Xunit;
#pragma warning disable CS0618 // Type or member is obsolete

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceConstructorTests
{
    private const string ExpectedJsonSerializerFieldName = "_jsonSerializerOptions";
    private const string ExpectedHttpContentSerializerFieldName = "_httpContentSerializer";

    private readonly ShopifyApiCredentials _credentials = new(Utils.MyShopifyUrl, Utils.AccessToken);
    private readonly JsonSerializerOptions _expectedJsonSerializerOptions = new() { AllowTrailingCommas = true, PropertyNameCaseInsensitive = true };
    private readonly IHttpContentSerializer _expectedHttpContentSerializer = A.Fake<IHttpContentSerializer>();
    private readonly IShopifyDomainUtility _shopifyDomainUtility = A.Fake<IShopifyDomainUtility>();
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

        sut.Should()
            .HavePrivateMember(ExpectedJsonSerializerFieldName)
            .And
            .BeOfType<JsonSerializerOptions>()
            .Which
            .Should()
            .NotBeNull();

        sut.Should()
            .HavePrivateMember(ExpectedHttpContentSerializerFieldName)
            .And
            .BeOfType<IHttpContentSerializer>()
            .Which
            .Should()
            .NotBeNull();
    }

    [Fact]
    public void ConstructorWithShopifyApiCredentials_WhenApiVersionIsNotNull_ShouldUseApiVersion()
    {
        // Setup
        const string expectedApiVersion = "some-api-version";
        IDependencyContainer? dependencyContainer = null;

        // Act
        var sut = new GraphService(_credentials, expectedApiVersion, dependencyContainer);

        // Assert
        sut.APIVersion.Should().Be(expectedApiVersion);
    }

    [Fact]
    public void ConstructorWithShopifyApiCredentials_WhenDependencyContainerIsNotNull_ShouldUseDependenciesFromContainer()
    {
        // Setup
        string? apiVersion = null;
        var callToJsonSerializerOptions = A.CallTo(() => _dependencyContainer.TryGetService<JsonSerializerOptions>());
        var callToHttpContentSerializer = A.CallTo(() => _dependencyContainer.TryGetService<IHttpContentSerializer>());

        callToJsonSerializerOptions.Returns(_expectedJsonSerializerOptions);
        callToHttpContentSerializer.Returns(_expectedHttpContentSerializer);

        // Act
        var sut = new GraphService(_credentials, apiVersion, _dependencyContainer);

        // Assert
        sut.APIVersion.Should().NotBeNullOrEmpty();

        sut.Should()
            .HavePrivateMember(ExpectedJsonSerializerFieldName)
            .And
            .BeOfType<JsonSerializerOptions>()
            .Which
            .Should()
            .BeSameAs(_expectedJsonSerializerOptions);

        sut.Should()
            .HavePrivateMember(ExpectedHttpContentSerializerFieldName)
            .And
            .BeOfType<IHttpContentSerializer>()
            .Which
            .Should()
            .BeSameAs(_expectedHttpContentSerializer);

        callToHttpContentSerializer.MustHaveHappenedOnceExactly();
        callToJsonSerializerOptions.MustHaveHappenedOnceExactly();
    }

    #endregion

    #region Constructor with string credentials

    [Fact]
    public void ConstructorWithStringCredentials_WhenOptionalParametersAreNull_ShouldUseDefaults()
    {
        // Setup
        string? apiVersion = null;
        IDependencyContainer? dependencyContainer = null;

        // Act
        var sut = new GraphService(_credentials.ShopDomain, _credentials.AccessToken, apiVersion, dependencyContainer);

        // Assert
        sut.APIVersion.Should().NotBeNullOrEmpty();

        sut.Should()
            .HavePrivateMember(ExpectedJsonSerializerFieldName)
            .And
            .BeOfType<JsonSerializerOptions>()
            .Which
            .Should()
            .NotBeNull();

        sut.Should()
            .HavePrivateMember(ExpectedHttpContentSerializerFieldName)
            .And
            .BeOfType<IHttpContentSerializer>()
            .Which
            .Should()
            .NotBeNull();
    }

    [Fact]
    public void ConstructorWithStringCredentials_WhenApiVersionIsNotNull_ShouldUseApiVersion()
    {
        // Setup
        const string expectedApiVersion = "some-api-version";
        IDependencyContainer? dependencyContainer = null;

        // Act
        var sut = new GraphService(_credentials.ShopDomain, _credentials.AccessToken, expectedApiVersion, dependencyContainer);

        // Assert
        sut.APIVersion.Should().Be(expectedApiVersion);
    }

    [Fact]
    public void ConstructorWithStringCredentials_WhenDependencyContainerIsNotNull_ShouldUseDependenciesFromContainer()
    {
        // Setup
        string? apiVersion = null;
        var callToJsonSerializerOptions = A.CallTo(() => _dependencyContainer.TryGetService<JsonSerializerOptions>());
        var callToHttpContentSerializer = A.CallTo(() => _dependencyContainer.TryGetService<IHttpContentSerializer>());

        callToJsonSerializerOptions.Returns(_expectedJsonSerializerOptions);
        callToHttpContentSerializer.Returns(_expectedHttpContentSerializer);

        // Act
        var sut = new GraphService(_credentials.ShopDomain, _credentials.AccessToken, apiVersion, _dependencyContainer);

        // Assert
        sut.APIVersion.Should().NotBeNullOrEmpty();

        sut.Should()
            .HavePrivateMember(ExpectedJsonSerializerFieldName)
            .And
            .BeOfType<JsonSerializerOptions>()
            .Which
            .Should()
            .BeSameAs(_expectedJsonSerializerOptions);

        sut.Should()
            .HavePrivateMember(ExpectedHttpContentSerializerFieldName)
            .And
            .BeOfType<IHttpContentSerializer>()
            .Which
            .Should()
            .BeSameAs(_expectedHttpContentSerializer);

        callToHttpContentSerializer.MustHaveHappenedOnceExactly();
        callToJsonSerializerOptions.MustHaveHappenedOnceExactly();
    }

    #endregion

    #region Constructor with ShopifyDomainUtility

    [Fact]
    public void ConstructorWithShopifyDomainUtility_WhenShopifyDomainUtilityIsNull_ShouldNotThrow()
    {
        // Act
        var act = () => new GraphService(_credentials.ShopDomain, _credentials.AccessToken, null!);

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void ConstructorWithShopifyDomainUtility_ShouldUseDefaultDependencies()
    {
        // Act
        var sut = new GraphService(_credentials.ShopDomain, _credentials.AccessToken, _shopifyDomainUtility);

        // Assert
        sut.APIVersion.Should().NotBeNullOrEmpty();

        sut.Should()
            .HavePrivateMember(ExpectedJsonSerializerFieldName)
            .And
            .BeOfType<JsonSerializerOptions>()
            .Which
            .Should()
            .NotBeNull();

        sut.Should()
            .HavePrivateMember(ExpectedHttpContentSerializerFieldName)
            .And
            .BeOfType<IHttpContentSerializer>()
            .Which
            .Should()
            .NotBeNull();
    }

    #endregion
}
