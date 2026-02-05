#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A recurring billing agreement that associates an
/// [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) with a
/// merchant's shop. Each subscription contains one or more [`AppSubscriptionLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AppSubscriptionLineItem)
/// objects that define the pricing structure. The pricing structure can include
/// recurring charges, usage-based pricing, or both.
/// The subscription tracks billing details including the current period end date,
/// trial days, and [`AppSubscriptionStatus`](https://shopify.dev/docs/api/admin-graphql/latest/enums/AppSubscriptionStatus). 
/// Merchants must approve subscriptions through a [confirmation URL](https://shopify.dev/docs/api/admin-graphql/latest/mutations/appSubscriptionCreate#returns-confirmationUrl)
/// before billing begins. Test subscriptions allow developers to verify billing
/// flows without actual charges.
/// Learn more about [subscription
/// billing](https://shopify.dev/docs/apps/launch/billing/subscription-billing) and [testing charges](https://shopify.dev/docs/apps/launch/billing/managed-pricing#test-charges).
/// </summary>
public record AppSubscription : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the app subscription was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The date and time when the current app subscription period ends. Returns `null` if the subscription isn't active.
    /// </summary>
    [JsonPropertyName("currentPeriodEnd")]
    public DateTimeOffset? currentPeriodEnd { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The plans attached to the app subscription.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<AppSubscriptionLineItem>? lineItems { get; set; } = null;

    /// <summary>
    /// The name of the app subscription.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The URL that the merchant is redirected to after approving the app subscription.
    /// </summary>
    [JsonPropertyName("returnUrl")]
    public string? returnUrl { get; set; } = null;

    /// <summary>
    /// The status of the app subscription.
    /// </summary>
    [JsonPropertyName("status")]
    public AppSubscriptionStatus? status { get; set; } = null;

    /// <summary>
    /// Specifies whether the app subscription is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// The number of free trial days, starting at the subscription's creation date, by which billing is delayed.
    /// </summary>
    [JsonPropertyName("trialDays")]
    public int? trialDays { get; set; } = null;
}