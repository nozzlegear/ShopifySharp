#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class InventoryShipmentLineItemEdgeQueryBuilder() : GraphQueryBuilder<InventoryShipmentLineItemEdge>("query inventoryShipmentLineItemEdge")
{
    public InventoryShipmentLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryShipmentLineItemEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}