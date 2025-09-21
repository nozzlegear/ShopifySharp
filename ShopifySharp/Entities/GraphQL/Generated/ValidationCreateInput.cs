#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to install a validation.
/// </summary>
public record ValidationCreateInput : GraphQLInputObject<ValidationCreateInput>
{
    /// <summary>
    /// Whether the validation should block on failures other than expected violations.
    /// </summary>
    [JsonPropertyName("blockOnFailure")]
    public bool? blockOnFailure { get; set; } = null;

    /// <summary>
    /// Whether the validation should be live on the merchant checkout.
    /// </summary>
    [JsonPropertyName("enable")]
    public bool? enable { get; set; } = null;

    /// <summary>
    /// The function ID representing the extension to install.
    /// </summary>
    [JsonPropertyName("functionId")]
    public string? functionId { get; set; } = null;

    /// <summary>
    /// Additional metafields to associate to the validation.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The title of the validation.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}