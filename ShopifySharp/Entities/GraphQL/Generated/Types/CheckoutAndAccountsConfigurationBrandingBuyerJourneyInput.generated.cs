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
/// The input fields for updating breadcrumb customizations, which represent the buyer's journey to checkout.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingBuyerJourneyInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingBuyerJourneyInput>
{
    /// <summary>
    /// The visibility customizations for updating breadcrumbs, which represent the buyer's journey to checkout.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutAndAccountsConfigurationBrandingVisibility? visibility { get; set; } = null;
}