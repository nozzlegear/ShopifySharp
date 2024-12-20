using System.Reflection;
using FakeItEasy;
using ShopifySharp.Utilities;

namespace ShopifySharp.Extensions.DependencyInjection.Tests;

public class FactoryServiceTests
{
    private readonly ShopifyApiCredentials _credentials = new("some-shopify-domain", "some-access-token");
    private readonly ShopifyPartnerApiCredentials _partnerCredentials = new(7, "some-access-token");

    private static (Type FactoryClassType, Type ServiceInterfaceType)[] GetFactoryServiceTypes()
    {
        // Get all factory classes in the ShopifySharp.Factories namespace
        var factoryTypes = Assembly.GetAssembly(typeof(GraphServiceFactory))!
            .GetTypes()
            .Where(t =>
                t is
                {
                    IsClass: true,
                    Namespace: "ShopifySharp.Factories",
                    // Special handling to exclude the PartnerServiceFactory, which does not use the IServiceFactory interface
                    Name: not "PartnerServiceFactory"
                } &&
                t.Name.EndsWith("Factory"))
            .Select(factoryType =>
            {
                // Get the factory's service interface type (e.g. IOrderService, IGraphService, etc.)
                var serviceFactoryInterface = factoryType.GetInterface("IServiceFactory`1")!;
                var serviceInterfaceType = serviceFactoryInterface.GetGenericArguments().First();
                return (factoryType, serviceInterfaceType);
            })
            .ToArray();

        return factoryTypes;
    }

    [Fact]
    public void PartnerServiceFactory_ShouldUseServiceProviderConstructor()
    {
        // Setup
        var factoryServiceType = typeof(PartnerServiceFactory);
        var serviceInterfaceType = typeof(IPartnerService);
        var sut = A.Fake<IServiceProvider>(x => x.Strict());
        var getDomainServiceCall = A.CallTo(() => sut.GetService(typeof(IShopifyDomainUtility)));
        var getExecutionPolicyCall = A.CallTo(() => sut.GetService(typeof(IRequestExecutionPolicy)));

        getDomainServiceCall.Returns(A.Dummy<IShopifyDomainUtility>());
        getExecutionPolicyCall.Returns(A.Dummy<IRequestExecutionPolicy>());

        // Act
        var act = () =>
        {
            var factory = Activator.CreateInstance(factoryServiceType, sut) as IPartnerServiceFactory;
            factory.Should().BeOfType(factoryServiceType);
            return factory!.Create(_partnerCredentials);
        };

        // Assert
        act.Should()
            .NotThrow()
            .Subject
            .Should()
            .BeAssignableTo(serviceInterfaceType, "created service should implement the interface");
        getDomainServiceCall.MustHaveHappened();
        getExecutionPolicyCall.MustHaveHappened();
    }

    [Theory]
    [CombinatorialData]
    public void AllServiceFactories_ShouldUseServiceProviderConstructor(
        [CombinatorialMemberData(nameof(GetFactoryServiceTypes))] (Type, Type) types)
    {
        // Setup
        var (factoryServiceType, serviceInterfaceType) = types;
        var sut = A.Fake<IServiceProvider>(x => x.Strict());
        var getDomainServiceCall = A.CallTo(() => sut.GetService(typeof(IShopifyDomainUtility)));
        var getExecutionPolicyCall = A.CallTo(() => sut.GetService(typeof(IRequestExecutionPolicy)));

        getDomainServiceCall.Returns(A.Dummy<IShopifyDomainUtility>());
        getExecutionPolicyCall.Returns(A.Dummy<IRequestExecutionPolicy>());

        // Act
        var act = () =>
        {
            var factory = Activator.CreateInstance(factoryServiceType, sut) as IServiceFactory<IShopifyService>;
            factory.Should().BeOfType(factoryServiceType);
            return factory!.Create(_credentials);
        };

        // Assert
        act.Should()
            .NotThrow()
            .Which
            .Should()
            .BeAssignableTo(serviceInterfaceType, "created service should implement the interface");
        getDomainServiceCall.MustHaveHappened();
        getExecutionPolicyCall.MustHaveHappened();
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
