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
/// The input fields for customizing the Checkout surface.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceInput>
{
    /// <summary>
    /// The Checkout components.
    /// </summary>
    [JsonPropertyName("components")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutComponentsInput? components { get; set; } = null;
}