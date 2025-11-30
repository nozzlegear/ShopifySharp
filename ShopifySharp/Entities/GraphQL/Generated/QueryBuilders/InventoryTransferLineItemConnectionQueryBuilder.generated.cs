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

public class InventoryTransferLineItemConnectionQueryBuilder() : GraphQueryBuilder<InventoryTransferLineItemConnection>("inventoryTransferLineItemConnection")
{
    public InventoryTransferLineItemConnectionQueryBuilder AddFieldEdges(Func<InventoryTransferLineItemEdgeQueryBuilder, InventoryTransferLineItemEdgeQueryBuilder> build)
    {
        AddField<InventoryTransferLineItemEdge, InventoryTransferLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public InventoryTransferLineItemConnectionQueryBuilder AddFieldNodes(Func<InventoryTransferLineItemQueryBuilder, InventoryTransferLineItemQueryBuilder> build)
    {
        AddField<InventoryTransferLineItem, InventoryTransferLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public InventoryTransferLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}