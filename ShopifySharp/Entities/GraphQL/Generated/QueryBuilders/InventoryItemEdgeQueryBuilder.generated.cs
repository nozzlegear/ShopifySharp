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

public class InventoryItemEdgeQueryBuilder() : GraphQueryBuilder<InventoryItemEdge>("inventoryItemEdge")
{
    public InventoryItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryItemEdgeQueryBuilder AddFieldNode(Func<InventoryItemQueryBuilder, InventoryItemQueryBuilder> build)
    {
        AddField<InventoryItem, InventoryItemQueryBuilder>("node", build);
        return this;
    }
}