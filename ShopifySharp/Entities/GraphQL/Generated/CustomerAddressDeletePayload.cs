#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerAddressDelete` mutation.
/// </summary>
public record CustomerAddressDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the address deleted from the customer.
    /// </summary>
    [JsonPropertyName("deletedAddressId")]
    public string? deletedAddressId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}