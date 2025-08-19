#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to add more than one pricing plan to an app subscription.
/// </summary>
public record AppSubscriptionLineItemInput : GraphQLInputObject<AppSubscriptionLineItemInput>
{
    /// <summary>
    /// The pricing model for the app subscription.
    /// </summary>
    [JsonPropertyName("plan")]
    public AppPlanInput? plan { get; set; } = null;
}