#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `customerSendAccountInviteEmail` mutation.
/// </summary>
public record CustomerSendAccountInviteEmailPayload : IGraphQLObject
{
    /// <summary>
    /// The customer to whom an account invite email was sent.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerSendAccountInviteEmailUserError>? userErrors { get; set; } = null;
}