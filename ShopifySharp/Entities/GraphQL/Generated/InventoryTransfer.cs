#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the intention to move inventory between locations.
/// </summary>
public record InventoryTransfer : CommentEventEmbed, IGraphQLUnionCase, IGraphQLObject, ICommentEventSubject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, INode
{
    /// <summary>
    /// The date and time the inventory transfer was created in UTC format.
    /// </summary>
    [JsonPropertyName("dateCreated")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? dateCreated { get; set; } = null;

    /// <summary>
    /// Snapshot of the destination location (name, address, when snapped) with an
    /// optional link to the live Location object. If the original location is
    /// deleted, the snapshot data will still be available but the location link will be nil.
    /// </summary>
    [JsonPropertyName("destination")]
    public LocationSnapshot? destination { get; set; } = null;

    /// <summary>
    /// The list of events associated with the inventory transfer.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// Whether the merchant has added timeline comments to the inventory transfer.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The line items associated with the inventory transfer.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public InventoryTransferLineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// The number of line items associated with the inventory transfer. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("lineItemsCount")]
    public Count? lineItemsCount { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The name of the inventory transfer.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Additional note attached to the inventory transfer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// Snapshot of the origin location (name, address, when snapped) with an optional
    /// link to the live Location object. If the original location is deleted, the
    /// snapshot data will still be available but the location link will be nil.
    /// </summary>
    [JsonPropertyName("origin")]
    public LocationSnapshot? origin { get; set; } = null;

    /// <summary>
    /// The total quantity of items received in the transfer.
    /// </summary>
    [JsonPropertyName("receivedQuantity")]
    public int? receivedQuantity { get; set; } = null;

    /// <summary>
    /// The reference name of the inventory transfer.
    /// </summary>
    [JsonPropertyName("referenceName")]
    public string? referenceName { get; set; } = null;

    /// <summary>
    /// The shipments associated with the inventory transfer.
    /// </summary>
    [JsonPropertyName("shipments")]
    public InventoryShipmentConnection? shipments { get; set; } = null;

    /// <summary>
    /// The current status of the transfer.
    /// </summary>
    [JsonPropertyName("status")]
    public InventoryTransferStatus? status { get; set; } = null;

    /// <summary>
    /// A list of tags that have been added to the inventory transfer.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// The total quantity of items being transferred.
    /// </summary>
    [JsonPropertyName("totalQuantity")]
    public int? totalQuantity { get; set; } = null;
}