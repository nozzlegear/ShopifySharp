#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to edit an inventory transfer.
/// </summary>
public record InventoryTransferEditInput : GraphQLInputObject<InventoryTransferEditInput>
{
    /// <summary>
    /// The date the inventory transfer was created.
    /// </summary>
    [JsonPropertyName("dateCreated")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? dateCreated { get; set; } = null;

    /// <summary>
    /// The destination location for the inventory transfer. The destination location can only be
    /// changed for draft transfers.
    /// </summary>
    [JsonPropertyName("destinationId")]
    public string? destinationId { get; set; } = null;

    /// <summary>
    /// A note to add to the Inventory Transfer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The origin location for the inventory transfer. The origin location can only be changed
    /// for draft transfers.
    /// </summary>
    [JsonPropertyName("originId")]
    public string? originId { get; set; } = null;

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