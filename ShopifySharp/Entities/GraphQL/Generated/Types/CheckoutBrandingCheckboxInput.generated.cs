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
/// The input fields used to update the checkboxes customizations.
/// </summary>
public record CheckoutBrandingCheckboxInput : GraphQLInputObject<CheckoutBrandingCheckboxInput>
{
    /// <summary>
    /// The corner radius used for checkboxes.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;
}