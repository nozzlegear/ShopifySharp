#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The choice list customizations.
/// </summary>
public record CheckoutBrandingChoiceList : IGraphQLObject
{
    /// <summary>
    /// The settings that apply to the 'group' variant of ChoiceList.
    /// </summary>
    [JsonPropertyName("group")]
    public CheckoutBrandingChoiceListGroup? @group { get; set; } = null;
}