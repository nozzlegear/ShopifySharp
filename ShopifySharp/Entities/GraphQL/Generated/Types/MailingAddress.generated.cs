#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A physical mailing address. For example, a [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)'s
/// default address and an
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)'s
/// billing address are both mailing addresses. Stores standard address components,
/// customer name information, and company details.
/// The address includes geographic coordinates ([`latitude`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MailingAddress#field-MailingAddress.fields.latitude) and [`longitude`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MailingAddress#field-MailingAddress.fields.longitude)).
/// You can format addresses for display using the [`formatted`](https://shopify.dev/docs/api/admin-graphql/latest/objects/MailingAddress#field-MailingAddress.fields.formatted)
/// field with options to include or exclude name and company information.
/// </summary>
public record MailingAddress : IGraphQLObject, INode
{
    /// <summary>
    /// The first line of the address. Typically the street address or PO Box number.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the address. Typically the number of the apartment, suite, or unit.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The name of the city, district, village, or town.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The name of the customer's company or organization.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// Whether the address corresponds to recognized latitude and longitude values.
    /// </summary>
    [JsonPropertyName("coordinatesValidated")]
    public bool? coordinatesValidated { get; set; } = null;

    /// <summary>
    /// The name of the country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The two-letter code for the country of the address.
    /// For example, US.
    /// </summary>
    [JsonPropertyName("countryCode")]
    [Obsolete("Use `countryCodeV2` instead.")]
    public string? countryCode { get; set; } = null;

    /// <summary>
    /// The two-letter code for the country of the address.
    /// For example, US.
    /// </summary>
    [JsonPropertyName("countryCodeV2")]
    public CountryCode? countryCodeV2 { get; set; } = null;

    /// <summary>
    /// The first name of the customer.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// A formatted version of the address, customized by the provided arguments.
    /// </summary>
    [JsonPropertyName("formatted")]
    public ICollection<string>? formatted { get; set; } = null;

    /// <summary>
    /// A comma-separated list of the values for city, province, and country.
    /// </summary>
    [JsonPropertyName("formattedArea")]
    public string? formattedArea { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The last name of the customer.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The latitude coordinate of the customer address.
    /// </summary>
    [JsonPropertyName("latitude")]
    public decimal? latitude { get; set; } = null;

    /// <summary>
    /// The longitude coordinate of the customer address.
    /// </summary>
    [JsonPropertyName("longitude")]
    public decimal? longitude { get; set; } = null;

    /// <summary>
    /// The full name of the customer, based on firstName and lastName.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A unique phone number for the customer.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The region of the address, such as the province, state, or district.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The alphanumeric code for the region.
    /// For example, ON.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;

    /// <summary>
    /// The time zone of the address.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? timeZone { get; set; } = null;

    /// <summary>
    /// The validation status that is leveraged by the address validation feature in the Shopify Admin.
    /// See ["Validating addresses in your Shopify admin"](https://help.shopify.com/manual/fulfillment/managing-orders/validating-order-address)
    /// for more details.
    /// </summary>
    [JsonPropertyName("validationResultSummary")]
    public MailingAddressValidationResult? validationResultSummary { get; set; } = null;

    /// <summary>
    /// The zip or postal code of the address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}