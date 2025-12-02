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

public class InventoryLevelConnectionQueryBuilder() : GraphQueryBuilder<InventoryLevelConnection>("inventoryLevelConnection")
{
    public InventoryLevelConnectionQueryBuilder AddFieldEdges(Func<InventoryLevelEdgeQueryBuilder, InventoryLevelEdgeQueryBuilder> build)
    {
        AddField<InventoryLevelEdge, InventoryLevelEdgeQueryBuilder>("edges", build);
        return this;
    }

    public InventoryLevelConnectionQueryBuilder AddFieldNodes(Func<InventoryLevelQueryBuilder, InventoryLevelQueryBuilder> build)
    {
        AddField<InventoryLevel, InventoryLevelQueryBuilder>("nodes", build);
        return this;
    }

    public InventoryLevelConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}