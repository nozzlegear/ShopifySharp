using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp.Services;

public class ShopPlanService : GraphService, IShopPlanService
{
    public ShopPlanService(string shopDomain, string accessToken) : base(shopDomain, accessToken)
    {
    }

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
        var shop = result.SelectToken("shop");

        return shop.Value<ShopPlan>("plan");
    }

    /// <inheritdoc />
    public virtual async Task<bool> IsPartnerDevelopmentShopAsync(CancellationToken cancellationToken = default)
    {
        var plan = await GetShopPlanAsync(cancellationToken);
        return plan.PartnerDevelopment == true;
    }
}
