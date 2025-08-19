#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the payment terms template object.
/// </summary>
public record PaymentTermsTemplate : IGraphQLObject, INode
{
    /// <summary>
    /// The description of the payment terms template.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The number of days between the issued date and due date if this is the net type of payment terms.
    /// </summary>
    [JsonPropertyName("dueInDays")]
    public int? dueInDays { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the payment terms template.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The type of the payment terms template.
    /// </summary>
    [JsonPropertyName("paymentTermsType")]
    public PaymentTermsType? paymentTermsType { get; set; } = null;

    /// <summary>
    /// The translated payment terms template name.
    /// </summary>
    [JsonPropertyName("translatedName")]
    public string? translatedName { get; set; } = null;
}