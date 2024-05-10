using Newtonsoft.Json;

namespace ShopifySharp.WebhookPayloads.CartUpdated;

public class CartUpdatedPriceSet
{
    [JsonProperty("shop_money")]
    public CartUpdatedShopMoney ShopMoney { get; set; }

    [JsonProperty("presentment_money")]
    public CartUpdatedPresentmentMoney PresentmentMoney { get; set; }
}