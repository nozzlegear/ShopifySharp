using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp;

public class LineItemDuty : ShopifyObject
{
    [JsonProperty("harmonized_system_code")]
    public string HarmonizedSystemCode { get; set; }

    [JsonProperty("country_code_of_origin")]
    public string CountryCodeOfOrigin { get; set; }

    [JsonProperty("price_set")]
    public PriceSet PriceSet { get; set; }

    [JsonProperty("tax_lines")]
    public IEnumerable<TaxLine> TaxLines { get; set; }
}