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

public class InventoryScheduledChangeConnectionQueryBuilder() : GraphQueryBuilder<InventoryScheduledChangeConnection>("inventoryScheduledChangeConnection")
{
    public InventoryScheduledChangeConnectionQueryBuilder AddFieldEdges(Func<InventoryScheduledChangeEdgeQueryBuilder, InventoryScheduledChangeEdgeQueryBuilder> build)
    {
        AddField<InventoryScheduledChangeEdge, InventoryScheduledChangeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public InventoryScheduledChangeConnectionQueryBuilder AddFieldNodes(Func<InventoryScheduledChangeQueryBuilder, InventoryScheduledChangeQueryBuilder> build)
    {
        AddField<InventoryScheduledChange, InventoryScheduledChangeQueryBuilder>("nodes", build);
        return this;
    }

    public InventoryScheduledChangeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}