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
/// The input fields to use to update the choice list customizations.
/// </summary>
public record CheckoutBrandingChoiceListInput : GraphQLInputObject<CheckoutBrandingChoiceListInput>
{
    /// <summary>
    /// The settings that apply to the 'group' variant of ChoiceList.
    /// </summary>
    [JsonPropertyName("group")]
    public CheckoutBrandingChoiceListGroupInput? @group { get; set; } = null;
}