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
/// A comment that staff members add to the timeline of
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order), [`DraftOrder`](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder), [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer), [`InventoryTransfer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryTransfer),
/// [`Company`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Company), [`CompanyLocation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CompanyLocation), or [`PriceRule`](https://shopify.dev/docs/api/admin-graphql/latest/objects/PriceRule)
/// objects. Staff use comments to document internal notes, communicate with team
/// members, and track important information about these types.
/// The comment includes information like the [`StaffMember`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StaffMember)
/// who authored it, when it was created, and whether it's editable or deletable.
/// Comments can have file attachments and reference related objects like
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) or [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
/// objects through embeds.
/// </summary>
public record CommentEvent : IGraphQLObject, IEvent, INode
{
    /// <summary>
    /// The action that occured.
    /// </summary>
    [JsonPropertyName("action")]
    public string? action { get; set; } = null;

    /// <summary>
    /// The name of the app that created the event.
    /// </summary>
    [JsonPropertyName("appTitle")]
    public string? appTitle { get; set; } = null;

    /// <summary>
    /// The attachments associated with the comment event.
    /// </summary>
    [JsonPropertyName("attachments")]
    public ICollection<CommentEventAttachment>? attachments { get; set; } = null;

    /// <summary>
    /// Whether the event was created by an app.
    /// </summary>
    [JsonPropertyName("attributeToApp")]
    public bool? attributeToApp { get; set; } = null;

    /// <summary>
    /// Whether the event was caused by an admin user.
    /// </summary>
    [JsonPropertyName("attributeToUser")]
    public bool? attributeToUser { get; set; } = null;

    /// <summary>
    /// The name of the user that authored the comment event.
    /// </summary>
    [JsonPropertyName("author")]
    public StaffMember? author { get; set; } = null;

    /// <summary>
    /// Whether the comment event can be deleted. If true, then the comment event can be deleted.
    /// </summary>
    [JsonPropertyName("canDelete")]
    public bool? canDelete { get; set; } = null;

    /// <summary>
    /// Whether the comment event can be edited. If true, then the comment event can be edited.
    /// </summary>
    [JsonPropertyName("canEdit")]
    public bool? canEdit { get; set; } = null;

    /// <summary>
    /// The date and time when the event was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// Whether the event is critical.
    /// </summary>
    [JsonPropertyName("criticalAlert")]
    public bool? criticalAlert { get; set; } = null;

    /// <summary>
    /// Whether the comment event has been edited. If true, then the comment event has been edited.
    /// </summary>
    [JsonPropertyName("edited")]
    public bool? edited { get; set; } = null;

    /// <summary>
    /// The object reference associated with the comment event. For example, a product or discount).
    /// </summary>
    [JsonPropertyName("embed")]
    public CommentEventEmbed? embed { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Human readable text that describes the event.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// The raw body of the comment event.
    /// </summary>
    [JsonPropertyName("rawMessage")]
    public string? rawMessage { get; set; } = null;

    /// <summary>
    /// The parent subject to which the comment event belongs.
    /// </summary>
    [JsonPropertyName("subject")]
    public ICommentEventSubject? subject { get; set; } = null;
}