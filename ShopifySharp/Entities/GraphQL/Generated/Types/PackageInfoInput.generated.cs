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
/// The input fields that describe package information for the shipping label
/// purchase. Exactly one of `customPackage` or `carrierPackage` must be provided.
/// </summary>
public record PackageInfoInput : GraphQLInputObject<PackageInfoInput>
{
    /// <summary>
    /// A standard package provided by the carrier. Mutually exclusive with `customPackage`.
    /// </summary>
    [JsonPropertyName("carrierPackage")]
    public ShippingCarrierPackageInput? carrierPackage { get; set; } = null;

    /// <summary>
    /// A package with custom dimensions and empty-package weight. Mutually exclusive with `carrierPackage`.
    /// </summary>
    [JsonPropertyName("customPackage")]
    public ShippingLabelPurchaseCustomPackageInput? customPackage { get; set; } = null;
}