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
/// The input fields for a carrier-defined package to use for the shipping label purchase.
/// </summary>
public record ShippingCarrierPackageInput : GraphQLInputObject<ShippingCarrierPackageInput>
{
    /// <summary>
    /// The code identifying the carrier that supplies the package. Examples include
    /// `usps`, `ups_shipping`, `dhl_express`, and `canada_post`.
    /// </summary>
    [JsonPropertyName("carrierCode")]
    public string? carrierCode { get; set; } = null;

    /// <summary>
    /// The code identifying the carrier package type.
    /// </summary>
    [JsonPropertyName("carrierPackageCode")]
    public string? carrierPackageCode { get; set; } = null;

    /// <summary>
    /// The carrier-defined display name for the package.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}