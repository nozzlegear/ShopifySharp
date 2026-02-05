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
/// Defines the global color roles for checkout branding. These semantic colors
/// maintain consistency across all checkout elements and provide the foundation for
/// the checkout's visual design system.
/// Use global colors to:
/// - Set brand colors for primary actions and buttons
/// - Define accent colors for links and interactive elements
/// - Configure semantic colors for success, warning, and error states
/// - Apply decorative colors for visual highlights
/// For example, a merchant might set their brand blue for primary buttons, green
/// for success messages, amber for warnings, and red for critical errors, creating
/// a consistent color language throughout checkout.
/// Learn more about [checkout customization](https://shopify.dev/docs/api/admin-graphql/latest/objects/CheckoutBranding).
/// </summary>
public record CheckoutBrandingColorGlobal : IGraphQLObject
{
    /// <summary>
    /// A color used for interaction, like links and focus states.
    /// </summary>
    [JsonPropertyName("accent")]
    public string? accent { get; set; } = null;

    /// <summary>
    /// A color that's strongly associated with the merchant. Currently used for
    /// primary buttons, for example **Pay now**, and secondary buttons, for example **Buy again**.
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