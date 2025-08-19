#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a resource feedback object.
/// </summary>
public record ResourceFeedbackCreateInput : GraphQLInputObject<ResourceFeedbackCreateInput>
{
    /// <summary>
    /// The date and time when the feedback was generated. Used to help determine whether
    /// incoming feedback is outdated compared to existing feedback.
    /// </summary>
    [JsonPropertyName("feedbackGeneratedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? feedbackGeneratedAt { get; set; } = null;

    /// <summary>
    /// If the feedback state is `requires_action`, then you can send a string message
    /// that communicates the action to be taken by the merchant.
    /// The string must be a single message up to 100 characters long and must end with a period.
    /// You need to adhere to the message formatting rules or your requests will fail:
    /// - `[Explanation of the problem]. [Suggested action].`
    /// **Examples:**
    /// - `[Your app name]` isn't connected. Connect your account to use this sales channel. `[Learn more]`
    /// - `[Your app name]` isn't configured. Agree to the terms and conditions to use this app. `[Learn more]`
    /// Both `Your app name` and `Learn more` (a button which directs merchants to
    /// your app) are automatically populated in the Shopify admin.
    /// </summary>
    [JsonPropertyName("messages")]
    public ICollection<string>? messages { get; set; } = null;

    /// <summary>
    /// The state of the feedback and whether it requires merchant action.
    /// </summary>
    [JsonPropertyName("state")]
    public ResourceFeedbackState? state { get; set; } = null;
}