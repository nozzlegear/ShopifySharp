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

public class InventoryShipmentLineItemEdgeQueryBuilder() : GraphQueryBuilder<InventoryShipmentLineItemEdge>("inventoryShipmentLineItemEdge")
{
    public InventoryShipmentLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryShipmentLineItemEdgeQueryBuilder AddFieldNode(Func<InventoryShipmentLineItemQueryBuilder, InventoryShipmentLineItemQueryBuilder> build)
    {
        AddField<InventoryShipmentLineItem, InventoryShipmentLineItemQueryBuilder>("node", build);
        return this;
    }
}