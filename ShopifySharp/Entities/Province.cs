using Newtonsoft.Json;

namespace ShopifySharp;

public class Province : ShopifyObject
{
    /// <summary>
    /// The unique numeric identifier for the country.
    /// </summary>
    [JsonProperty("country_id")]
    public long? CountryId { get; set; }

    /// <summary>
    /// The name of the province or state.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The two letter province or state code.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    ///  The tax value in decimal format.
    /// </summary>
    [JsonProperty("tax")]
    public decimal? Tax { get; set; }

    /// <summary>
    /// The name of the tax as it is referred to in the applicable province/state. For example, in Ontario, Canada the tax is referred to as HST.
    /// </summary>
    [JsonProperty("tax_name")]
    public string TaxName { get; set; }

    /// <summary>
    /// A tax_type is applied for a compounded sales tax. For example, the Canadian HST is a compounded sales tax of both PST and GST.
    /// </summary>
    [JsonProperty("tax_type")]
    public string TaxType { get; set; }

    /// <summary>
    /// The unique numeric identifier for the shipping zone.
    /// </summary>
    [JsonProperty("shipping_zone_id")]
    public long? ShippingZoneId { get; set; }

    /// <summary>
    ///  The tax value in percent format.
    /// </summary>
    [JsonProperty("tax_percentage")]
    public decimal? TaxPercentage { get; set; }
}