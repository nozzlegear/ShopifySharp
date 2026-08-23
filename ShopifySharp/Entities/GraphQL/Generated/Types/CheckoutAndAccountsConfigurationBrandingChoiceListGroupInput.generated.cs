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
/// The input fields for customizing the 'group' variant of ChoiceList.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingChoiceListGroupInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingChoiceListGroupInput>
{
    /// <summary>
    /// The spacing between UI elements in the list.
    /// </summary>
    [JsonPropertyName("spacing")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? spacing { get; set; } = null;
}