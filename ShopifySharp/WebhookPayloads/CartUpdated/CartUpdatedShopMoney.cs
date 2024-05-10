using Newtonsoft.Json;

namespace ShopifySharp.WebhookPayloads.CartUpdated;

public class CartUpdatedShopMoney
{
    [JsonProperty("amount")]
    public decimal Amount { get; set; }

    [JsonProperty("currency_code")]
    public string CurrencyCode { get; set; }
}