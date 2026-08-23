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
/// The input fields for customizing the footer content.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingFooterContentInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingFooterContentInput>
{
    /// <summary>
    /// The visibility customizations for footer content.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutAndAccountsConfigurationBrandingVisibility? visibility { get; set; } = null;
}