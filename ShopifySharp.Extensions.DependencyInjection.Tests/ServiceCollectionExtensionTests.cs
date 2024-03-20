using ShopifySharp.Utilities;
using System.Reflection;

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
        var assembly = Assembly.GetAssembly(typeof(IServiceFactory<>));

        if (assembly == null)
        {
            throw new InvalidOperationException("No assembly found for IServiceFactory interface. Ensure you are scanning the correct assembly.");
        }

        var serviceFactoryTypes = assembly
            ?.GetTypes()
            .Where(t => t.IsInterface
                        && t.IsPublic
                        && t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IServiceFactory<>)))
            .ToList();

        if (serviceFactoryTypes == null || !serviceFactoryTypes.Any())
        {
            throw new InvalidOperationException("No IServiceFactory interfaces found. Ensure you are scanning the correct assembly.");
        }

        foreach (var serviceType in serviceFactoryTypes)
        {
            var resolvedService = serviceProvider.GetService(serviceType);
            var concreteType = assembly.GetType($"ShopifySharp.Factories.{serviceType.Name.Substring(1)}");

            resolvedService.Should()
                .NotBeNull()
                .And
                .BeOfType(concreteType);
        }
    }

    [Fact]
    public void AddShopifySharp_AddsRequestExecutionPolicy_AddsUtilities_ThenAddsServiceFactories()
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

    [Theory]
    [InlineData(ServiceLifetime.Scoped)]
    [InlineData(ServiceLifetime.Singleton)]
    [InlineData(ServiceLifetime.Transient)]
    public void AddShopifySharp_AddsRequestExecutionPolicy_AddsUtilities_ThenAddsServiceFactories_WithServiceLifetime(ServiceLifetime serviceLifetime)
    {
        // Setup
        var container = new ServiceCollection();

        // Act
        container.AddShopifySharp<TestRequestExecutionPolicy>(serviceLifetime);

        // Assert
        var serviceProvider = container.BuildServiceProvider();
        var domainUtility = serviceProvider.GetServiceInstances<IShopifyDomainUtility>();
        var policy = serviceProvider.GetServiceInstances<IRequestExecutionPolicy>();
        var orderServiceFactory = serviceProvider.GetServiceInstances<IOrderServiceFactory>();

        domainUtility.Instance1.Should()
           .NotBeNull()
           .And
           .ValidLifetimeInstance(domainUtility.Instance2
           .Should()
           .NotBeNull(), serviceLifetime);

        policy.Instance1.Should()
            .NotBeNull()
            .And
            .ValidLifetimeInstance(policy.Instance2
            .Should()
            .NotBeNull(), serviceLifetime);

        orderServiceFactory.Instance1.Should()
            .NotBeNull()
            .And
            .ValidLifetimeInstance(orderServiceFactory.Instance2
            .Should()
            .NotBeNull(), serviceLifetime);
    }
}