using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Utilities;

namespace ShopifySharp;

public class AssignedFulfillmentOrderService : ShopifyService, IAssignedFulfillmentOrderService
{
    /// <summary>
    /// Creates a new instance of <see cref="AssignedFulfillmentOrderService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public AssignedFulfillmentOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    internal AssignedFulfillmentOrderService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}

    public virtual async Task<ListResult<AssignedFulfillmentOrder>> ListAsync(ListFilter<AssignedFulfillmentOrder> filter, CancellationToken cancellationToken = default)
    {
        return await ExecuteGetListAsync("assigned_fulfillment_orders.json", "fulfillment_orders", filter, cancellationToken);
    }

    public virtual async Task<ListResult<AssignedFulfillmentOrder>> ListAsync(AssignedFulfillmentOrderFilter filter = null, CancellationToken cancellationToken = default)
    {
        return await ListAsync(filter?.AsListFilter(), cancellationToken);
    }
}
