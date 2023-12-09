
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
