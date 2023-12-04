using Newtonsoft.Json;

namespace ShopifySharp.Entities.CartUpdatedWebhook
{
    public class CartUpdatedWebhookOriginalLinePriceSet
    {
        [JsonProperty("shop_money")]
        public CartUpdatedWebhookShopMoney ShopMoney { get; set; }

        [JsonProperty("presentment_money")]
        public CartUpdatedWebhookPresentmentMoney PresentmentMoney { get; set; }
    }
}
