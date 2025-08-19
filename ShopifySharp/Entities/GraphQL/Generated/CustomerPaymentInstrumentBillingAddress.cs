#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record CustomerPaymentInstrumentCustomerCreditCard(CustomerCreditCard Value): CustomerPaymentInstrument;
internal record CustomerPaymentInstrumentCustomerPaypalBillingAgreement(CustomerPaypalBillingAgreement Value): CustomerPaymentInstrument;
internal record CustomerPaymentInstrumentCustomerShopPayAgreement(CustomerShopPayAgreement Value): CustomerPaymentInstrument;
#endif /// <summary>

/// The billing address of a payment instrument.
/// </summary>
public record CustomerPaymentInstrumentBillingAddress : IGraphQLObject
{
    /// <summary>
    /// The first line of the address. Typically the street address or PO Box number.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The name of the city, district, village, or town.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

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
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The name of the buyer of the address.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

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
    /// The zip or postal code of the address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}