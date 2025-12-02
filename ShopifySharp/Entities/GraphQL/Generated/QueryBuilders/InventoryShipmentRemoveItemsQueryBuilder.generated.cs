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

public class InventoryShipmentRemoveItemsQueryBuilder() : GraphQueryBuilder<InventoryShipmentRemoveItemsPayload>("inventoryShipmentRemoveItems"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public InventoryShipmentRemoveItemsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public InventoryShipmentRemoveItemsQueryBuilder AddArgumentLineItems(ICollection<string>? lineItems)
    {
        AddArgument("lineItems", lineItems);
        return this;
    }
}