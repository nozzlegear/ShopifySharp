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
/// Defines the visual styling for checkbox elements throughout the checkout
/// interface, focusing on corner radius customization. This allows merchants to
/// align checkbox appearance with their overall design aesthetic.
/// For example, a modern minimalist brand might prefer sharp, square checkboxes
/// while a friendly consumer brand could opt for rounded corners to create a
/// softer, more approachable feel.
/// The corner radius setting ensures checkboxes integrate seamlessly with the
/// overall checkout design language and brand identity.
/// </summary>
public record CheckoutBrandingCheckbox : IGraphQLObject
{
    /// <summary>
    /// The corner radius used for checkboxes.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;
}