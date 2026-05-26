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
/// The input fields for customizing the choice list.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingChoiceListInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingChoiceListInput>
{
    /// <summary>
    /// The 'group' variant of ChoiceList.
    /// </summary>
    [JsonPropertyName("group")]
    public CheckoutAndAccountsConfigurationBrandingChoiceListGroupInput? @group { get; set; } = null;
}