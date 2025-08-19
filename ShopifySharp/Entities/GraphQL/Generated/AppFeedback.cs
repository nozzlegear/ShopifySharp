#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Reports the status of shops and their resources and displays this information
/// within Shopify admin. AppFeedback is used to notify merchants about steps they need to take
/// to set up an app on their store.
/// </summary>
public record AppFeedback : IGraphQLObject
{
    /// <summary>
    /// The application associated to the feedback.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The date and time when the app feedback was generated.
    /// </summary>
    [JsonPropertyName("feedbackGeneratedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? feedbackGeneratedAt { get; set; } = null;

    /// <summary>
    /// A link to where merchants can resolve errors.
    /// </summary>
    [JsonPropertyName("link")]
    public Link? link { get; set; } = null;

    /// <summary>
    /// The feedback message presented to the merchant.
    /// </summary>
    [JsonPropertyName("messages")]
    public ICollection<UserError>? messages { get; set; } = null;

    /// <summary>
    /// Conveys the state of the feedback and whether it requires merchant action or not.
    /// </summary>
    [JsonPropertyName("state")]
    public ResourceFeedbackState? state { get; set; } = null;
}