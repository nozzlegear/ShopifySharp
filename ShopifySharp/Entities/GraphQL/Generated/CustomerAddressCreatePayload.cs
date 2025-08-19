#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerAddressCreate` mutation.
/// </summary>
public record CustomerAddressCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created address.
    /// </summary>
    [JsonPropertyName("address")]
    public MailingAddress? address { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}