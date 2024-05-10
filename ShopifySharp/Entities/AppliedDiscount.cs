using Newtonsoft.Json;

namespace ShopifySharp;

public class AppliedDiscount 
{
    /// <summary>
    /// Title of the discount.
    /// </summary>
    [JsonProperty("title")]
    public string Title { get; set; }

    /// <summary>
    /// Reason for the discount.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// he value of the discount. If the type of the discount is fixed_amount, then this is a fixed dollar amount. If the type is percentage, then this is the percentage.
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; }

    /// <summary>
    /// The type of discount. Known values are "percentage" and "fixed_amount".
    /// </summary>
    [JsonProperty("value_type")]
    public string ValueType { get; set; }

    /// <summary>
    /// The applied amount of the discount, based on the setting of value_type. 
    /// When ValueType is set to fixed_amount discount amount = quantity * value
    /// When ValueType is set to percentage discount amount = floor(price * quantity * value) / 100
    /// </summary>      
    [JsonProperty("amount")]
    public decimal? Amount { get; set; }
}