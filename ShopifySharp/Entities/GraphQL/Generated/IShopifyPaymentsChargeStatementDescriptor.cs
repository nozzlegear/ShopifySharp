#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The charge descriptors for a payments account.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(ShopifyPaymentsDefaultChargeStatementDescriptor), typeDiscriminator: "ShopifyPaymentsDefaultChargeStatementDescriptor")]
[JsonDerivedType(typeof(ShopifyPaymentsJpChargeStatementDescriptor), typeDiscriminator: "ShopifyPaymentsJpChargeStatementDescriptor")]
public interface IShopifyPaymentsChargeStatementDescriptor : IGraphQLObject
{
    /// <summary>
    /// The default charge statement descriptor.
    /// </summary>
    [JsonPropertyName("default")]
    public string? @default { get; set; }

    /// <summary>
    /// The prefix of the statement descriptor.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? prefix { get; set; }
}