#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerAddressUpdate` mutation.
/// </summary>
public record CustomerAddressUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated address.
    /// </summary>
    [JsonPropertyName("address")]
    public MailingAddress? address { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}