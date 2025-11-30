#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class InventoryShipmentReceiveQueryBuilder() : GraphQueryBuilder<InventoryShipmentReceivePayload>("inventoryShipmentReceive"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public InventoryShipmentReceiveQueryBuilder AddArgumentBulkReceiveAction(InventoryShipmentReceiveLineItemReason? bulkReceiveAction)
    {
        AddArgument("bulkReceiveAction", bulkReceiveAction);
        return this;
    }

    public InventoryShipmentReceiveQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public InventoryShipmentReceiveQueryBuilder AddArgumentLineItems(ICollection<InventoryShipmentReceiveItemInput>? lineItems)
    {
        AddArgument("lineItems", lineItems);
        return this;
    }
}