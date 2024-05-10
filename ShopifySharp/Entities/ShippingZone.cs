using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// This is used to view shipping zones, their countries, provinces, and shipping rates.
/// </summary>
public class ShippingZone : ShopifyObject
{
    /// <summary>
    /// The name of the shipping zone, specified by the user.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// A list of countries that belong to the shipping zone.
    /// </summary>
    [JsonProperty("countries")]
    public IEnumerable<Country> Countries { get; set; }

    /// <summary>
    /// Information about weight based shipping rates used.
    /// </summary>
    [JsonProperty("weight_based_shipping_rates")]
    public IEnumerable<WeightBasedShippingRate> WeightBasedShippingRates { get; set; }

    /// <summary>
    /// Information about price based shipping rates used.
    /// </summary>
    [JsonProperty("price_based_shipping_rates")]
    public IEnumerable<PriceBasedShippingRate> PriceBasedShippingRates { get; set; }

    /// <summary>
    /// Information about carrier shipping providers and the rates used.
    /// </summary>
    [JsonProperty("carrier_shipping_rate_providers")]
    public IEnumerable<CarrierShippingRateProvider> CarrierShippingRateProviders { get; set; }
}