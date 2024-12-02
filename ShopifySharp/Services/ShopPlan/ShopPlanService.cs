#nullable enable
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Infrastructure;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// A service for getting the shop's current Shopify subscription plan. This is a convenience wrapper around the Shopify GraphQL API.
public class ShopPlanService : GraphService, IShopPlanService
{
    private readonly JsonSerializerOptions _jsonSerializerOptions;

    public ShopPlanService(string shopDomain, string accessToken, IDependencyContainer? dependencyContainer) : base(shopDomain, accessToken, null, dependencyContainer)
    {
        _jsonSerializerOptions = InitializeDependencies(dependencyContainer);
    }

    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    internal ShopPlanService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility)
    {
        _jsonSerializerOptions = InitializeDependencies(null);
    }

    private static JsonSerializerOptions InitializeDependencies(IDependencyContainer? dependencyContainer)
    {
        var jsonSerializerOptions = InternalDependencyContainerConsolidation.GetServiceOrDefault(
            dependencyContainer,
            () => Serializer.GraphSerializerOptions
        );
        return jsonSerializerOptions;
    }

    /// <inheritdoc />
    public virtual async Task<ShopPlan> GetShopPlanAsync(CancellationToken cancellationToken = default)
    {
        const string query = """
            query {
                shop {
                    plan {
                        ...on ShopPlan {
                            displayName
                            partnerDevelopment
                            shopifyPlus
                        }
                    }
                }
            }
        """;
        var result = await PostAsync(new GraphRequest
        {
            Query = query,
            EstimatedQueryCost = 1,
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        }, cancellationToken);

        return result.RootElement.GetProperty("shop")
            .GetProperty("plan")
            .Deserialize<ShopPlan>(_jsonSerializerOptions)!;
    }

    /// <inheritdoc />
    public virtual async Task<bool> IsPartnerDevelopmentShopAsync(CancellationToken cancellationToken = default)
    {
        var plan = await GetShopPlanAsync(cancellationToken);
        return plan.PartnerDevelopment == true;
    }
}
