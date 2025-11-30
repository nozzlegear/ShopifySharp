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

public class InventoryLevelEdgeQueryBuilder() : GraphQueryBuilder<InventoryLevelEdge>("inventoryLevelEdge")
{
    public InventoryLevelEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryLevelEdgeQueryBuilder AddFieldNode(Func<InventoryLevelQueryBuilder, InventoryLevelQueryBuilder> build)
    {
        AddField<InventoryLevel, InventoryLevelQueryBuilder>("node", build);
        return this;
    }
}