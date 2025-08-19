#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A result of a discount redeem code creation operation created by a bulk creation.
/// </summary>
public record DiscountRedeemCodeBulkCreationCode : IGraphQLObject
{
    /// <summary>
    /// The code to use in the discount redeem code creation operation.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The successfully created discount redeem code.
    /// If the discount redeem code couldn't be created, then this field is `null``.
    /// </summary>
    [JsonPropertyName("discountRedeemCode")]
    public DiscountRedeemCode? discountRedeemCode { get; set; } = null;

    /// <summary>
    /// A list of errors that occurred during the creation operation of the discount redeem code.
    /// </summary>
    [JsonPropertyName("errors")]
    public ICollection<DiscountUserError>? errors { get; set; } = null;
}