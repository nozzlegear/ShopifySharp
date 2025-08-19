#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to customize the overall look and feel of the checkout.
/// </summary>
public record CheckoutBrandingColorGlobalInput : GraphQLInputObject<CheckoutBrandingColorGlobalInput>
{
    /// <summary>
    /// A color used for interaction, like links and focus states.
    /// </summary>
    [JsonPropertyName("accent")]
    public string? accent { get; set; } = null;

    /// <summary>
    /// A color that's strongly associated with the merchant. Currently used for
    /// primary buttons, such as **Pay now**, and secondary buttons, such as **Buy again**.
    /// </summary>
    [JsonPropertyName("brand")]
    public string? brand { get; set; } = null;

    /// <summary>
    /// A semantic color used for components that communicate critical content. For
    /// example, a blocking error such as the requirement to enter a valid credit card number.
    /// </summary>
    [JsonPropertyName("critical")]
    public string? critical { get; set; } = null;

    /// <summary>
    /// A color used to highlight certain areas of the user interface. For example, the [`Text`](https://shopify.dev/docs/api/checkout-ui-extensions/latest/components/titles-and-text/text#textprops-propertydetail-appearance) component.
    /// </summary>
    [JsonPropertyName("decorative")]
    public string? decorative { get; set; } = null;

    /// <summary>
    /// A semantic color used for components that communicate general, informative content.
    /// </summary>
    [JsonPropertyName("info")]
    public string? info { get; set; } = null;

    /// <summary>
    /// A semantic color used for components that communicate successful actions or a positive state.
    /// </summary>
    [JsonPropertyName("success")]
    public string? success { get; set; } = null;

    /// <summary>
    /// A semantic color used for components that display content that requires
    /// attention. For example, something that might be wrong, but not blocking.
    /// </summary>
    [JsonPropertyName("warning")]
    public string? warning { get; set; } = null;
}