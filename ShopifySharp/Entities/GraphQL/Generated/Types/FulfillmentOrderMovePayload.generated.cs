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
/// Return type for `fulfillmentOrderMove` mutation.
/// </summary>
public record FulfillmentOrderMovePayload : IGraphQLObject
{
    /// <summary>
    /// The fulfillment order which now contains the moved line items and is assigned to the destination location.
    /// If the original fulfillment order doesn't have any line items which are fully
    /// or partially fulfilled, the original fulfillment order will be moved to the new location.
    /// However if this isn't the case, the moved fulfillment order will differ from the original one.
    /// </summary>
    [JsonPropertyName("movedFulfillmentOrder")]
    public FulfillmentOrder? movedFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The final state of the original fulfillment order.
    /// As a result of the move operation, the original fulfillment order might be moved to the new location
    /// or remain in the original location. The original fulfillment order might have the same status or be closed.
    /// </summary>
    [JsonPropertyName("originalFulfillmentOrder")]
    public FulfillmentOrder? originalFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// This field is deprecated.
    /// </summary>
    [JsonPropertyName("remainingFulfillmentOrder")]
    public FulfillmentOrder? remainingFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}