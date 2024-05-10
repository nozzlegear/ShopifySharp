using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp;

public class Country : ShopifyObject
{
    /// <summary>
    /// The full name of the country, in English.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The tax value in decimal format.
    /// </summary>
    /// <returns></returns>
    [JsonProperty("tax")]
    public decimal? Tax { get; set; }

    /// <summary>
    /// The ISO 3166-1 alpha-2 two-letter country code for the country. The code for a given country will be the same as the code for the same country in another shop.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// The name of the tax as it is referred to in the applicable province/state. For example, in Ontario, Canada the tax is referred to as HST.
    /// </summary>
    [JsonProperty("tax_name")]
    public string TaxName { get; set; }

    /// <summary>
    /// The sub-regions of a country. The term provinces also encompasses states.
    /// </summary>
    [JsonProperty("provinces")]
    public IEnumerable<Province> Provinces { get; set; }
}