#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `discountRedeemCodeBulkAdd` mutation.
/// </summary>
public record DiscountRedeemCodeBulkAddPayload : IGraphQLObject
{
    /// <summary>
    /// The ID of bulk operation that creates multiple unique discount codes.
    /// You can use the
    /// [`discountRedeemCodeBulkCreation` query](https://shopify.dev/api/admin-graphql/latest/queries/discountRedeemCodeBulkCreation)
    /// to track the status of the bulk operation.
    /// </summary>
    [JsonPropertyName("bulkCreation")]
    public DiscountRedeemCodeBulkCreation? bulkCreation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}