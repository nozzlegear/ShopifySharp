using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp;

public interface IShopPlanService : IShopifyService
{
    /// Uses Shopify's GraphQL API to get the shop's subscription plan.
    Task<ShopPlan> GetShopPlanAsync(CancellationToken cancellationToken = default);

    /// Uses Shopify's GraphQL API to check if the shop is a development shop. Returns true if 
    /// `shop.plan.partnerDevelopment` is true.
    Task<bool> IsPartnerDevelopmentShopAsync(CancellationToken cancellationToken = default);
}
