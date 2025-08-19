#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the content container customizations.
/// </summary>
public record CheckoutBrandingContentInput : GraphQLInputObject<CheckoutBrandingContentInput>
{
    /// <summary>
    /// Divider style and visibility on the content container.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingContainerDividerInput? divider { get; set; } = null;
}