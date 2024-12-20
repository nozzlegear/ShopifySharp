#nullable enable
using System;
using System.Text.Json;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Http;
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
    private readonly IServiceProvider _serviceProvider = A.Fake<IServiceProvider>();

    #region Constructor with ShopifyApiCredentials and ShopifyDomainUtility

    [Fact]
    public void ConstructorWithShopifyApiCredentialsAndShopifyDomainUtility_WhenOptionalParametersAreNull_ShouldUseDefaults()
    {
        // Setup
        string? apiVersion = null;
        IShopifyDomainUtility? shopifyDomainUtility = null;

        // Act
        var sut = new GraphService(_credentials, apiVersion, shopifyDomainUtility);

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
    public void ConstructorWithShopifyApiCredentialsAndShopifyDomainUtility_WhenApiVersionIsNotNull_ShouldUseApiVersion()
    {
        // Setup
        const string expectedApiVersion = "some-api-version";
        IShopifyDomainUtility? shopifyDomainUtility = null;

        // Act
        var sut = new GraphService(_credentials, expectedApiVersion, shopifyDomainUtility);

        // Assert
        sut.APIVersion.Should().Be(expectedApiVersion);
    }

    #endregion

    #region Constructor with IServiceProvider

    // [Fact]
    // public void ConstructorWithServiceProvider_WhenProviderDoesNotHaveRequiredDependency_ShouldUseDefault()
    // {
    //
    // }

    // [Fact]
    // public void ConstructorWithServiceProvider_WhenProviderHasDependencies_ShouldUseDependenciesFromServiceProvider()
    // {
    //     // Setup
    //     string? apiVersion = null;
    //     var callToJsonSerializerOptions = A.CallTo(() => _serviceProvider.GetService(typeof(JsonSerializerOptions)));
    //     var callToHttpContentSerializer = A.CallTo(() => _serviceProvider.GetService(typeof(IHttpContentSerializer)));
    //
    //     callToJsonSerializerOptions.Returns(_expectedJsonSerializerOptions);
    //     callToHttpContentSerializer.Returns(_expectedHttpContentSerializer);
    //
    //     // Act
    //     var sut = new GraphService(_credentials, apiVersion, _serviceProvider);
    //
    //     // Assert
    //     sut.APIVersion.Should().NotBeNullOrEmpty();
    //
    //     sut.Should()
    //         .HavePrivateMember(ExpectedJsonSerializerFieldName)
    //         .And
    //         .BeOfType<JsonSerializerOptions>()
    //         .Which
    //         .Should()
    //         .BeSameAs(_expectedJsonSerializerOptions);
    //
    //     sut.Should()
    //         .HavePrivateMember(ExpectedHttpContentSerializerFieldName)
    //         .And
    //         .BeOfType<IHttpContentSerializer>()
    //         .Which
    //         .Should()
    //         .BeSameAs(_expectedHttpContentSerializer);
    //
    //     callToHttpContentSerializer.MustHaveHappenedOnceExactly();
    //     callToJsonSerializerOptions.MustHaveHappenedOnceExactly();
    // }

    #endregion

    #region Constructor with string credentials and API version

    [Fact]
    public void ConstructorWithStringCredentialsAndApiVersion_WhenOptionalParametersAreNull_ShouldUseDefaults()
    {
        // Setup
        string? apiVersion = null;

        // Act
        var sut = new GraphService(_credentials.ShopDomain, _credentials.AccessToken, apiVersion);

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
    public void ConstructorWithStringCredentialsAndApiVersion_WhenApiVersionIsNotNull_ShouldUseApiVersion()
    {
        // Setup
        const string expectedApiVersion = "some-api-version";

        // Act
        var sut = new GraphService(_credentials.ShopDomain, _credentials.AccessToken, expectedApiVersion);

        // Assert
        sut.APIVersion.Should().Be(expectedApiVersion);
    }

    #endregion

    #region Constructor with string credentials and ShopifyDomainUtility

    [Fact]
    public void ConstructorWithStringCredentialsAndShopifyDomainUtility_WhenShopifyDomainUtilityIsNull_ShouldNotThrow()
    {
        // Act
        IShopifyDomainUtility? shopifyDomainUtility = null;
        var act = () => new GraphService(_credentials.ShopDomain, _credentials.AccessToken, shopifyDomainUtility!);

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void ConstructorWithStringCredentialsAndShopifyDomainUtility_ShouldUseDefaultDependencies()
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
