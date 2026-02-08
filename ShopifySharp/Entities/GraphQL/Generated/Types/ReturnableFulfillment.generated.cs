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
/// A delivered order that's eligible to be returned to the merchant. Provides the
/// items from completed fulfillments that customers can select when initiating a return.
/// Use returnable fulfillments to determine which items are eligible for return
/// before creating a
/// [`Return`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Return) with the [`returnCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/returnCreate)
/// mutation. The line items show quantities that are available for return.
/// Learn more about [building return management workflows](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management).
/// </summary>
public record ReturnableFulfillment : IGraphQLObject, INode
{
    /// <summary>
    /// The fulfillment that the returnable fulfillment refers to.
    /// </summary>
    [JsonPropertyName("fulfillment")]
    public Fulfillment? fulfillment { get; set; } = null;

    /// <summary>
    /// The unique ID of the Returnable Fulfillment.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of returnable fulfillment line items.
    /// </summary>
    [JsonPropertyName("returnableFulfillmentLineItems")]
    public ReturnableFulfillmentLineItemConnection? returnableFulfillmentLineItems { get; set; } = null;
}