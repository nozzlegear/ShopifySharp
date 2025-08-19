#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `checkoutBrandingUpsert` mutation.
/// </summary>
public record CheckoutBrandingUpsertPayload : IGraphQLObject
{
    /// <summary>
    /// Returns the new checkout branding settings.
    /// </summary>
    [JsonPropertyName("checkoutBranding")]
    public CheckoutBranding? checkoutBranding { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CheckoutBrandingUpsertUserError>? userErrors { get; set; } = null;
}