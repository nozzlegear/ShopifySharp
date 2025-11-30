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

public class InventoryTransferLineItemEdgeQueryBuilder() : GraphQueryBuilder<InventoryTransferLineItemEdge>("query inventoryTransferLineItemEdge")
{
    public InventoryTransferLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryTransferLineItemEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}