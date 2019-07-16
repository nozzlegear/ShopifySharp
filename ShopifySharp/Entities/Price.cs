using Newtonsoft.Json;

namespace ShopifySharp
{
    public class Price
    {
        /// <summary>
        /// The three-letter code (ISO 4217 format) for currency.
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The variant's price or compare-at price in the currency.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }
    }
}