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

public class InventoryShipmentSetTrackingQueryBuilder() : GraphQueryBuilder<InventoryShipmentSetTrackingPayload>("inventoryShipmentSetTracking"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public InventoryShipmentSetTrackingQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public InventoryShipmentSetTrackingQueryBuilder AddArgumentTracking(InventoryShipmentTrackingInput? tracking)
    {
        AddArgument("tracking", tracking);
        return this;
    }
}