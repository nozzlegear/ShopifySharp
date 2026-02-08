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
public record CheckoutBrandingBuyerJourneyInput : GraphQLInputObject<CheckoutBrandingBuyerJourneyInput>
{
    /// <summary>
    /// The visibility customizations for updating breadcrumbs, which represent the buyer's journey to checkout.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}