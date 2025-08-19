#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create and update a payment customization.
/// </summary>
public record PaymentCustomizationInput : GraphQLInputObject<PaymentCustomizationInput>
{
    /// <summary>
    /// The enabled status of the payment customization.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// The ID of the function providing the payment customization.
    /// </summary>
    [JsonPropertyName("functionId")]
    public string? functionId { get; set; } = null;

    /// <summary>
    /// Additional metafields to associate to the payment customization.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The title of the payment customization.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}