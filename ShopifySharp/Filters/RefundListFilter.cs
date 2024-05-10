using Newtonsoft.Json;

namespace ShopifySharp.Filters;

public class RefundListFilter : ListFilter<Refund>
{
    /// <summary>
    /// Show amounts in the shop currency for the underlying transaction. Default: false.
    /// </summary>
    [JsonProperty("in_shop_currency")]
    public bool? InShopCurrency { get; set; }
}