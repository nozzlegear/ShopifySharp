#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a reverse label.
/// </summary>
public record ReverseDeliveryLabelInput : GraphQLInputObject<ReverseDeliveryLabelInput>
{
    /// <summary>
    /// The URL of the label file. If a label file was uploaded to be attached to the
    /// delivery, then provide the temporary staged URL.
    /// </summary>
    [JsonPropertyName("fileUrl")]
    public string? fileUrl { get; set; } = null;
}