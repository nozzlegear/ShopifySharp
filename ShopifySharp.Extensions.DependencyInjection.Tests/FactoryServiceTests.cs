using FakeItEasy;
using ShopifySharp.Utilities;

namespace ShopifySharp.Extensions.DependencyInjection.Tests;

public class FactoryServiceTests
{
    private readonly ShopifyApiCredentials _credentials = new("some-shopify-domain", "some-access-token");

    [Fact]
    public void FactoryServices_WhenConstructingService_ShouldUseServiceProviderConstructor()
    {
        // Setup
        var sut = A.Fake<IServiceProvider>(x => x.Strict());
        var factory = new OrderServiceFactory(sut);
        var getDomainServiceCall = A.CallTo(() => sut.GetService(typeof(IShopifyDomainUtility)));
        var getExecutionPolicyCall = A.CallTo(() => sut.GetService(typeof(IRequestExecutionPolicy)));

        getDomainServiceCall.Returns(A.Dummy<IShopifyDomainUtility>());
        getExecutionPolicyCall.Returns(A.Dummy<IRequestExecutionPolicy>());

        // Act
        var act = () => factory.Create(_credentials);

        // Assert
        act.Should()
            .NotThrow()
            .Subject
            .Should()
            .BeOfType<OrderService>();
        getDomainServiceCall.MustHaveHappened();
        getExecutionPolicyCall.MustHaveHappened();
    }

    [Fact]
    public void FactoryServices_WhenConstructingFactoryViaObsoleteConstructor_ShouldPassServicesToInternalServiceProvider()
    {

    }

    [Fact]
    public void FactoryServices_WhenRequestExecutionPolicyIsNotInjected_ShouldCreateService()
    {
        // Setup
        var container = new ServiceCollection();
        container.AddShopifySharpServiceFactories();
        var serviceProvider = container.BuildServiceProvider();

        // Act
        var orderServiceFactory = serviceProvider.GetRequiredService<IOrderServiceFactory>();
        var act = () => orderServiceFactory.Create(_credentials);

        // Assert
        act.Should()
            .NotThrow()
            .Subject
            .Should()
            .BeOfType<OrderService>();
    }

    [Fact]
    public async Task FactoryServices_WhenRequestExecutionPolicyIsInjected_ShouldCreateServiceWithThePolicy()
    {
        // Setup
        var container = new ServiceCollection();
        container.AddShopifySharpServiceFactories();
        container.AddShopifySharpRequestExecutionPolicy<TestRequestExecutionPolicy>();
        var serviceProvider = container.BuildServiceProvider();

        // Act
        var orderServiceFactory = serviceProvider.GetRequiredService<IOrderServiceFactory>();
        var orderService = orderServiceFactory.Create(_credentials);
        var act = () => orderService.ListAsync();

        // Assert
        await act.Should()
            .ThrowAsync<TestException>();
    }

    [Fact]
    public void FactoryServices_WhenDomainUtilityIsInjected_ShouldCreateServiceWithTheUtility()
    {
        // Setup
        var container = new ServiceCollection();
        container.AddShopifySharpServiceFactories();
        container.AddShopifySharpUtilities(options =>
        {
            options.DomainUtility = new TestDomainUtility();
        });
        var serviceProvider = container.BuildServiceProvider();

        // Act
        var orderServiceFactory = serviceProvider.GetRequiredService<IOrderServiceFactory>();
        // The constructor will use the domain utility to turn the domain string into an uri
        var act = () => orderServiceFactory.Create(_credentials);

        // Assert
        act.Should().Throw<TestException>();
    }
}
