using ShopifySharp.Utilities;

namespace ShopifySharp.Extensions.DependencyInjection.Tests;

public class ServiceCollectionExtensionTests
{
    [Fact]
    public void AddShopifySharpRequestExecutionPolicy_AddsThePolicy()
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        container.AddShopifySharpRequestExecutionPolicy<TestRequestExecutionPolicy>();

        // Assert
        var serviceProvider = container.BuildServiceProvider();
        var policy = serviceProvider.GetService<IRequestExecutionPolicy>();

        policy.Should()
            .NotBeNull()
            .And
            .BeOfType<TestRequestExecutionPolicy>();
    }

    [Fact]
    public void AddShopifySharpRequestExecutionPolicy_AllowsAddingMoreThanOnePolicy()
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        container.AddShopifySharpRequestExecutionPolicy<DefaultRequestExecutionPolicy>()
            .AddShopifySharpRequestExecutionPolicy<LeakyBucketExecutionPolicy>()
            .AddShopifySharpRequestExecutionPolicy<TestRequestExecutionPolicy>();

        // Assert
        var serviceProvider = container.BuildServiceProvider();
        var policy = serviceProvider.GetService<IRequestExecutionPolicy>();

        policy.Should()
            .NotBeNull()
            .And
            .BeOfType<TestRequestExecutionPolicy>();
    }

    [Fact]
    public void AddShopifySharpUtilities_AddsUtilities()
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        var serviceProvider = container.AddShopifySharpUtilities()
            .BuildServiceProvider();

        // Assert
        serviceProvider.GetService<IShopifyDomainUtility>()
            .Should()
            .NotBeNull()
            .And.BeOfType<ShopifyDomainUtility>()
            .And.BeAssignableTo<IShopifyDomainUtility>();
        serviceProvider.GetService<IShopifyOauthUtility>()
            .Should()
            .NotBeNull()
            .And.BeOfType<ShopifyOauthUtility>()
            .And.BeAssignableTo<IShopifyOauthUtility>();
        serviceProvider.GetService<IShopifyRequestValidationUtility>()
            .Should()
            .NotBeNull()
            .And.BeOfType<ShopifyRequestValidationUtility>()
            .And.BeAssignableTo<IShopifyRequestValidationUtility>();
    }

    [Fact]
    public void AddShopifySharpUtilities_HandlesNullUtilities()
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        var serviceProvider = container.AddShopifySharpUtilities(options =>
            {
                options.DomainUtility = null;
                options.OauthUtility = null;
                options.RequestValidationUtility = null;
            })
            .BuildServiceProvider();

        // Assert
        serviceProvider.GetService<IShopifyDomainUtility>()
            .Should()
            .NotBeNull()
            .And.BeOfType<ShopifyDomainUtility>()
            .And.BeAssignableTo<IShopifyDomainUtility>();
        serviceProvider.GetService<IShopifyOauthUtility>()
            .Should()
            .NotBeNull()
            .And.BeOfType<ShopifyOauthUtility>()
            .And.BeAssignableTo<IShopifyOauthUtility>();
        serviceProvider.GetService<IShopifyRequestValidationUtility>()
            .Should()
            .NotBeNull()
            .And.BeOfType<ShopifyRequestValidationUtility>()
            .And.BeAssignableTo<IShopifyRequestValidationUtility>();
    }

    [Fact]
    public void AddShopifySharpUtilities_AddsCustomUtilities()
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        var domainUtility = container.AddShopifySharpUtilities(options =>
            {
                options.DomainUtility = new TestDomainUtility();
            })
            .BuildServiceProvider()
            .GetService<IShopifyDomainUtility>();
        var getUri = () => domainUtility!.BuildShopDomainUri("some-shop-domain");

        // Assert
        domainUtility.Should()
            .NotBeNull()
            .And.BeOfType<TestDomainUtility>()
            .And.BeAssignableTo<IShopifyDomainUtility>();

        getUri.Should().Throw<TestException>();
    }

    [Fact]
    public void AddShopifySharpServiceFactories_AddsServiceFactories()
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        container.AddShopifySharpServiceFactories();

        // Assert
        var serviceProvider = container.BuildServiceProvider();
        var orderServiceFactory = serviceProvider.GetService<IOrderServiceFactory>();

        orderServiceFactory.Should()
            .NotBeNull()
            .And
            .BeOfType<OrderServiceFactory>();
    }

    [Fact]
    public void AddShopifySharp_AddsRequestExecutionPolicy_ThenAddsServiceFactories()
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        container.AddShopifySharp<TestRequestExecutionPolicy>();

        // Assert
        var serviceProvider = container.BuildServiceProvider();
        var policy = serviceProvider.GetService<IRequestExecutionPolicy>();
        var orderServiceFactory = serviceProvider.GetService<IOrderServiceFactory>();

        policy.Should()
            .NotBeNull()
            .And
            .BeOfType<TestRequestExecutionPolicy>();

        orderServiceFactory.Should()
            .NotBeNull()
            .And
            .BeOfType<OrderServiceFactory>();
    }
}
