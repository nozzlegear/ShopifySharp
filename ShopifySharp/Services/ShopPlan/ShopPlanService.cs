#nullable enable
using System;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Infrastructure;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// A service for getting the shop's current Shopify subscription plan. This is a convenience wrapper around the Shopify GraphQL API.
public class ShopPlanService : GraphService, IShopPlanService
{
    public ShopPlanService(string shopDomain, string accessToken, IDependencyContainer? dependencyContainer) : base(shopDomain, accessToken, null, dependencyContainer)
    {
    }

    [Obsolete("This constructor is deprecated and will be removed in a future version of ShopifySharp.")]
    internal ShopPlanService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility)
    {
    }

    /// <inheritdoc />
    public virtual async Task<ShopPlan> GetShopPlanAsync(CancellationToken cancellationToken = default)
    {
        var query = """
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
        var result = await this.PostAsync(query, 1, cancellationToken);

        return result.SelectToken("shop.plan").ToObject<ShopPlan>();
    }

    /// <inheritdoc />
    public virtual async Task<bool> IsPartnerDevelopmentShopAsync(CancellationToken cancellationToken = default)
    {
        var plan = await GetShopPlanAsync(cancellationToken);
        return plan.PartnerDevelopment == true;
    }
}
