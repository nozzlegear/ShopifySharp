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
/// The choice list customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingChoiceList : IGraphQLObject
{
    /// <summary>
    /// The 'group' variant of ChoiceList.
    /// </summary>
    [JsonPropertyName("group")]
    public CheckoutAndAccountsConfigurationBrandingChoiceListGroup? @group { get; set; } = null;
}