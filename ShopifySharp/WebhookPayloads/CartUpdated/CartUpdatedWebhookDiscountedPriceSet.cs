using Newtonsoft.Json;

namespace ShopifySharp.WebhookPayloads.CartUpdated
{
    public class CartUpdatedWebhookDiscountedPriceSet
    {
        [JsonProperty("shop_money")]
        public CartUpdatedWebhookShopMoney ShopMoney { get; set; }

        [JsonProperty("presentment_money")]
        public CartUpdatedWebhookPresentmentMoney PresentmentMoney { get; set; }
    }
}
