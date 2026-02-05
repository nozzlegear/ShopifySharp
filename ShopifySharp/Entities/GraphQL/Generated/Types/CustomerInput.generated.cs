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
/// The input fields and values to use when creating or updating a customer.
/// </summary>
public record CustomerInput : GraphQLInputObject<CustomerInput>
{
    /// <summary>
    /// The unique email address of the customer.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// Information that describes when the customer consented to receiving marketing
    ///         material by email. The `email` field is required when creating a customer with email marketing
    ///         consent information.
    /// </summary>
    [JsonPropertyName("emailMarketingConsent")]
    public CustomerEmailMarketingConsentInput? emailMarketingConsent { get; set; } = null;

    /// <summary>
    /// The customer's first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The ID of the customer to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The customer's last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The customer's locale.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// Additional metafields to associate to the customer.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// A unique identifier for the customer that's used with Multipass login.
    /// </summary>
    [JsonPropertyName("multipassIdentifier")]
    public string? multipassIdentifier { get; set; } = null;

    /// <summary>
    /// A note about the customer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The unique phone number for the customer.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The marketing consent information when the customer consented to receiving marketing
    ///         material by SMS. The `phone` field is required when creating a customer with SMS
    ///         marketing consent information.
    /// </summary>
    [JsonPropertyName("smsMarketingConsent")]
    public CustomerSmsMarketingConsentInput? smsMarketingConsent { get; set; } = null;

    /// <summary>
    /// A list of tags to associate with the customer. Can be an array or a
    /// comma-separated list. Example values: `["tag1", "tag2", "tag3"]`, `"tag1, tag2, tag3"`
    /// Updating `tags` overwrites any existing tags that were previously added to the
    /// customer. To add new tags without overwriting
    /// existing tags, use the [tagsAdd](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd)
    /// mutation.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// Whether the customer is exempt from paying taxes on their order.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;

    /// <summary>
    /// The list of tax exemptions to apply to the customer.
    /// </summary>
    [JsonPropertyName("taxExemptions")]
    public ICollection<TaxExemption>? taxExemptions { get; set; } = null;
}