using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PriceSet
    {
        [JsonProperty("shop_money")]
        public Price ShopMoney { get; set; }

        [JsonProperty("presentment_money")]
        public Price PresentmentMoney { get; set; }
    }
}