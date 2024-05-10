using Newtonsoft.Json;
using System;

namespace ShopifySharp;

/// <summary>
/// An object representing a physical store location.
/// </summary>
public class Location : ShopifyObject
{
    /// <summary>
    /// Whether the location is active.
    /// </summary>
    [JsonProperty("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// The name of the location.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The first line of the address.
    /// </summary>
    [JsonProperty("address1")]
    public string Address1 { get; set; }

    /// <summary>
    /// The second line of the address.
    /// </summary>
    [JsonProperty("address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// The zip or postal code.
    /// </summary>
    [JsonProperty("zip")]
    public string Zip { get; set; }

    /// <summary>
    /// The city the location is in.
    /// </summary>
    [JsonProperty("city")]
    public string City { get; set; }

    /// <summary>
    /// The province the location is in.
    /// </summary>
    [JsonProperty("province")]
    public string Province { get; set; }

    /// <summary>
    /// The code of the province the location is in.
    /// </summary>
    [JsonProperty("province_code")]
    public string ProvinceCode { get; set; }

    /// <summary>
    /// The country the location is in.
    /// </summary>
    [JsonProperty("country")]
    public string Country { get; set; }

    /// <summary>
    /// The name of the country the location is in.
    /// </summary>
    [JsonProperty("country_name")]
    public string CountryName { get; set; }

    /// <summary>
    /// The code of the country the location is in.
    /// </summary>
    [JsonProperty("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The phone number of the location. Can contain special chars like - and +.
    /// </summary>
    [JsonProperty("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The date and time when the location was created.
    /// </summary>
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// The date and time when the location was last updated.
    /// </summary>
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Whether this is a fulfillment service location. If true, then the location is a fulfillment service location. If false, then the location was created by the merchant and isn't tied to a fulfillment service.
    /// </summary>
    [JsonProperty("legacy")]
    public bool? Legacy { get; set; }

    /// <summary>
    /// The localized name of the location's country.
    /// </summary>
    [JsonProperty("localized_country_name")]
    public string LocalizedCountryName { get; set; }

    /// <summary>
    /// The localized name of the location's region. Typically a province, state, or prefecture.
    /// </summary>
    [JsonProperty("localized_province_name")]
    public string LocalizedProvinceName { get; set; }
}