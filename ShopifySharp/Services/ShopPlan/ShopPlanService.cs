#nullable enable
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// A service for getting the shop's current Shopify subscription plan. This is a convenience wrapper around the Shopify GraphQL API.
public class ShopPlanService : GraphService, IShopPlanService
{
    private readonly JsonSerializerOptions _jsonSerializerOptions = Serializer.GraphSerializerOptions;

    public ShopPlanService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, null, shopifyDomainUtility) { }

    public ShopPlanService(string shopDomain, string accessToken, IShopifyDomainUtility? shopifyDomainUtility = null) : this(new ShopifyApiCredentials(shopDomain, accessToken), shopifyDomainUtility) { }

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

        return result.Json
            .RootElement
            .GetProperty("data")
            .GetProperty("shop")
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
