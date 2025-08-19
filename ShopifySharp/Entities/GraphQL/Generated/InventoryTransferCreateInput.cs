#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create an inventory transfer.
/// </summary>
public record InventoryTransferCreateInput : GraphQLInputObject<InventoryTransferCreateInput>
{
    /// <summary>
    /// The date and time the inventory transfer was created. If left blank, defaults to the current date and time in UTC format.
    /// </summary>
    [JsonPropertyName("dateCreated")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? dateCreated { get; set; } = null;

    /// <summary>
    /// The destination location for the inventory transfer.
    /// </summary>
    [JsonPropertyName("destinationLocationId")]
    public string? destinationLocationId { get; set; } = null;

    /// <summary>
    /// The list of line items for the inventory transfer.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<InventoryTransferLineItemInput>? lineItems { get; set; } = null;

    /// <summary>
    /// A note to add to the Inventory Transfer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The origin location for the inventory transfer.
    /// </summary>
    [JsonPropertyName("originLocationId")]
    public string? originLocationId { get; set; } = null;

    /// <summary>
    /// The reference name to add to the inventory transfer.
    /// </summary>
    [JsonPropertyName("referenceName")]
    public string? referenceName { get; set; } = null;

    /// <summary>
    /// The tags to add to the inventory transfer.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;
}