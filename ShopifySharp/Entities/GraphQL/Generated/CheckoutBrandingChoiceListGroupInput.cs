#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to update the settings that apply to the 'group' variant of ChoiceList.
/// </summary>
public record CheckoutBrandingChoiceListGroupInput : GraphQLInputObject<CheckoutBrandingChoiceListGroupInput>
{
    /// <summary>
    /// The spacing between UI elements in the list.
    /// </summary>
    [JsonPropertyName("spacing")]
    public CheckoutBrandingSpacingKeyword? spacing { get; set; } = null;
}