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
/// The input fields for selecting a preferred shipping rate by carrier and service codes.
/// </summary>
public record PreferredRateSelectionInput : GraphQLInputObject<PreferredRateSelectionInput>
{
    /// <summary>
    /// The code identifying the carrier for the preferred rate. Examples include
    /// `usps`, `ups_shipping`, `dhl_express`, and `canada_post`.
    /// </summary>
    [JsonPropertyName("carrierCode")]
    public string? carrierCode { get; set; } = null;

    /// <summary>
    /// The carrier-defined service code for the preferred rate.
    /// </summary>
    [JsonPropertyName("serviceCode")]
    public string? serviceCode { get; set; } = null;
}