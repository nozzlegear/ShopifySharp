using Newtonsoft.Json;

namespace ShopifySharp
{
    public class CheckoutShippingRate
    {
        public CheckoutShippingRate()
        {

        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phoneRequired")]
        public bool PhoneRequired { get; set; }

        /// <summary>
        /// As of 2019-01-21, the type of this property is unknown. In Shopify's documentation, it only appears as a null value.
        /// </summary>
        [JsonProperty("deliveryRange")]
        public object DeliveryRange { get; set; }

        [JsonProperty("checkout")]
        public CheckoutShippingRatePrices Checkout { get; set; }
    }
}