using Newtonsoft.Json;

namespace ShopifySharp;

public class TaxLine
{
    /// <summary>
    /// Whether the channel that submitted the tax line is responsible for remitting it.
    /// </summary>
    [JsonProperty("channelLiable")]
    public bool ChannelLiable { get; set; }

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
    /// The proportion of the line item price represented by the tax, expressed as a percentage.
    /// </summary>
    [JsonProperty("ratePercentage")]
    public decimal? RatePercentage { get; set; }

    /// <summary>
    /// The origin of the tax.
    /// </summary>
    [JsonProperty("source")]
    public string Source { get; set; }

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