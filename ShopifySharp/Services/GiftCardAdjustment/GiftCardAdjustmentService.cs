using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for adjusting existing Shopify gift cards.
/// </summary>
public class GiftCardAdjustmentService : ShopifyService, IGiftCardAdjustmentService
{
    /// <summary>
    /// Creates a new instance of <see cref="GiftCardAdjustmentService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public GiftCardAdjustmentService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal GiftCardAdjustmentService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal GiftCardAdjustmentService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    public virtual async Task<IEnumerable<GiftCardAdjustment>> ListAsync(long giftCardId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<IEnumerable<GiftCardAdjustment>>($"gift_cards/{giftCardId}/adjustments.json", "adjustments", cancellationToken: cancellationToken);

    public virtual async Task<GiftCardAdjustment> GetAsync(long giftCardId, long adjustmentId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync< GiftCardAdjustment>($"gift_cards/{giftCardId}/adjustments/{adjustmentId}.json", "adjustment", cancellationToken: cancellationToken);

    public virtual async Task<GiftCardAdjustment> CreateAsync(long giftCardId, GiftCardAdjustment adjustment, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"gift_cards/{giftCardId}/adjustments.json");
        var content = new JsonContent(new
        {
            adjustment = adjustment
        });

        var response = await ExecuteRequestAsync<GiftCardAdjustment>(req, HttpMethod.Post, cancellationToken, content, "adjustment");
        return response.Result;
    }
}