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

public class InventoryShipmentEdgeQueryBuilder() : GraphQueryBuilder<InventoryShipmentEdge>("query inventoryShipmentEdge")
{
    public InventoryShipmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryShipmentEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}