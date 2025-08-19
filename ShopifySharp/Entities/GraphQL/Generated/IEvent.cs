#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Events chronicle resource activities such as the creation of an article, the fulfillment of an order, or the
/// addition of a product.
/// </summary>
public interface IEvent : IGraphQLObject
{
    /// <summary>
    /// The action that occured.
    /// </summary>
    [JsonPropertyName("action")]
    public string? action { get; set; }

    /// <summary>
    /// The name of the app that created the event.
    /// </summary>
    [JsonPropertyName("appTitle")]
    public string? appTitle { get; set; }

    /// <summary>
    /// Whether the event was created by an app.
    /// </summary>
    [JsonPropertyName("attributeToApp")]
    public bool? attributeToApp { get; set; }

    /// <summary>
    /// Whether the event was caused by an admin user.
    /// </summary>
    [JsonPropertyName("attributeToUser")]
    public bool? attributeToUser { get; set; }

    /// <summary>
    /// The date and time when the event was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; }

    /// <summary>
    /// Whether the event is critical.
    /// </summary>
    [JsonPropertyName("criticalAlert")]
    public bool? criticalAlert { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// Human readable text that describes the event.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; }
}