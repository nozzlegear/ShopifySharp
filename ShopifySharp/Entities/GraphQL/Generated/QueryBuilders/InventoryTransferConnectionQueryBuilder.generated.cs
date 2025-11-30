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

public class InventoryTransferConnectionQueryBuilder() : GraphQueryBuilder<InventoryTransferConnection>("inventoryTransferConnection")
{
    public InventoryTransferConnectionQueryBuilder AddFieldEdges(Func<InventoryTransferEdgeQueryBuilder, InventoryTransferEdgeQueryBuilder> build)
    {
        AddField<InventoryTransferEdge, InventoryTransferEdgeQueryBuilder>("edges", build);
        return this;
    }

    public InventoryTransferConnectionQueryBuilder AddFieldNodes(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("nodes", build);
        return this;
    }

    public InventoryTransferConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}