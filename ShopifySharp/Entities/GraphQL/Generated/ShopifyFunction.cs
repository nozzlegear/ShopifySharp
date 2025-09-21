#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A Shopify Function.
/// </summary>
public record ShopifyFunction : IGraphQLObject
{
    /// <summary>
    /// The API type of the Shopify Function.
    /// </summary>
    [JsonPropertyName("apiType")]
    public string? apiType { get; set; } = null;

    /// <summary>
    /// The API version of the Shopify Function.
    /// </summary>
    [JsonPropertyName("apiVersion")]
    public string? apiVersion { get; set; } = null;

    /// <summary>
    /// The app that owns the Shopify Function.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The App Bridge information for the Shopify Function.
    /// </summary>
    [JsonPropertyName("appBridge")]
    public FunctionsAppBridge? appBridge { get; set; } = null;

    /// <summary>
    /// The client ID of the app that owns the Shopify Function.
    /// </summary>
    [JsonPropertyName("appKey")]
    public string? appKey { get; set; } = null;

    /// <summary>
    /// The description of the Shopify Function.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The ID of the Shopify Function.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The input query of the Shopify Function.
    /// </summary>
    [JsonPropertyName("inputQuery")]
    public string? inputQuery { get; set; } = null;

    /// <summary>
    /// The title of the Shopify Function.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// If the Shopify Function uses the creation UI in the Admin.
    /// </summary>
    [JsonPropertyName("useCreationUi")]
    public bool? useCreationUi { get; set; } = null;
}