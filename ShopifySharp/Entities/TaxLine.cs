using Newtonsoft.Json;

namespace ShopifySharp;

public class TaxLine
{
    /// <summary>
    /// The amount of tax to be charged.
    /// </summary>
    [JsonProperty("price")]
    public decimal? Price { get; set; }

    /// <summary>
    /// The rate of tax to be applied.
    /// </summary>
    [JsonProperty("rate")]
    public decimal? Rate { get; set; }

    /// <summary>
    /// The name of the tax.
    /// </summary>
    [JsonProperty("title")]
    public string Title { get; set; }

    /// <summary>
    /// The amount added to the order for this tax in shop and presentment currencies.
    /// </summary>
    [JsonProperty("price_set")]
    public PriceSet PriceSet { get; set; }
}