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

public class InventoryItemConnectionQueryBuilder() : GraphQueryBuilder<InventoryItemConnection>("inventoryItemConnection")
{
    public InventoryItemConnectionQueryBuilder AddFieldEdges(Func<InventoryItemEdgeQueryBuilder, InventoryItemEdgeQueryBuilder> build)
    {
        AddField<InventoryItemEdge, InventoryItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public InventoryItemConnectionQueryBuilder AddFieldNodes(Func<InventoryItemQueryBuilder, InventoryItemQueryBuilder> build)
    {
        AddField<InventoryItem, InventoryItemQueryBuilder>("nodes", build);
        return this;
    }

    public InventoryItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}