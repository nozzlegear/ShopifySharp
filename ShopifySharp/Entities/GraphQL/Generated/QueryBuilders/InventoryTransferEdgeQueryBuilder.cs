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

public class InventoryTransferEdgeQueryBuilder() : GraphQueryBuilder<InventoryTransferEdge>("query inventoryTransferEdge")
{
    public InventoryTransferEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryTransferEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}