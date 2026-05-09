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
/// The input fields for customizing the content container.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingContentInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingContentInput>
{
    /// <summary>
    /// Divider style and visibility on the content container.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutAndAccountsConfigurationBrandingContainerDividerInput? divider { get; set; } = null;
}