using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp;

/// <summary>
/// An object representing a Shopify event.
/// </summary>
public class Event : ShopifyObject
{
    /// <summary>
    /// Refers to a certain event and its resources.
    /// </summary>
    [JsonProperty("arguments")]
    public IEnumerable<object> Arguments { get; set; }

    /// <summary>
    /// A text field containing information about the event.
    /// </summary>
    [JsonProperty("body")]
    public string Body { get; set; }

    /// <summary>
    /// The date and time when the event was created.
    /// </summary>
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// A relative URL to the resource the event is for (may be null)
    /// </summary>
    [JsonProperty("path")]
    public string Path { get; set; }

    /// <summary>
    /// Human readable text that describes the event (may contain limited HTML formatting).
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }

    /// <summary>
    /// The id of the resource that generated the event.
    /// </summary>
    [JsonProperty("subject_id")]
    public long? SubjectId { get; set; }

    /// <summary>
    /// The type of the resource that generated the event.
    /// </summary>
    [JsonProperty("subject_type")]
    public string SubjectType { get; set; }

    /// <summary>
    /// The type of event that took place.
    /// </summary>
    [JsonProperty("verb")]
    public string Verb { get; set; }

    /// <summary>
    /// Undocumented by Shopify
    /// </summary>
    [JsonProperty("author")]
    public string Author { get; set; }
}