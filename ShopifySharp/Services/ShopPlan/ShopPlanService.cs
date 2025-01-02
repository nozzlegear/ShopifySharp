#nullable enable
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// A service for getting the shop's current Shopify subscription plan. This is a convenience wrapper around the Shopify GraphQL API.
public class ShopPlanService : GraphService, IShopPlanService
{
    private readonly IJsonSerializer _jsonSerializer;

    internal ShopPlanService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider)
        : base(shopifyApiCredentials, serviceProvider)
    {
        _jsonSerializer = InitializeDependencies(serviceProvider);
    }

    public ShopPlanService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null)
        : base(shopifyApiCredentials, null, shopifyDomainUtility)
    {
        _jsonSerializer = InitializeDependencies(null);
    }

    public ShopPlanService(string shopDomain, string accessToken, IShopifyDomainUtility? shopifyDomainUtility = null)
        : this(new ShopifyApiCredentials(shopDomain, accessToken), shopifyDomainUtility)
    {
        _jsonSerializer = InitializeDependencies(null);
    }

    private static IJsonSerializer InitializeDependencies(IServiceProvider? serviceProvider)
    {
        var jsonSerializer = InternalServiceResolver.GetServiceOrDefault<IJsonSerializer>(
            serviceProvider,
            () => new SystemJsonSerializer(GetJsonSerializerOptions()));

        return jsonSerializer;

        JsonSerializerOptions GetJsonSerializerOptions() => InternalServiceResolver.GetServiceOrDefault(serviceProvider, () => Serializer.GraphSerializerOptions);
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

        return _jsonSerializer.Deserialize<ShopPlan>(result.Json
            .GetProperty("data")
            .GetProperty("shop")
            .GetProperty("plan"))!;
    }

    /// <inheritdoc />
    public virtual async Task<bool> IsPartnerDevelopmentShopAsync(CancellationToken cancellationToken = default)
    {
        var plan = await GetShopPlanAsync(cancellationToken);
        return plan.PartnerDevelopment == true;
    }
}
