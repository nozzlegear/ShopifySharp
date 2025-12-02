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

public class InventoryShipmentLineItemConnectionQueryBuilder() : GraphQueryBuilder<InventoryShipmentLineItemConnection>("inventoryShipmentLineItemConnection")
{
    public InventoryShipmentLineItemConnectionQueryBuilder AddFieldEdges(Func<InventoryShipmentLineItemEdgeQueryBuilder, InventoryShipmentLineItemEdgeQueryBuilder> build)
    {
        AddField<InventoryShipmentLineItemEdge, InventoryShipmentLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public InventoryShipmentLineItemConnectionQueryBuilder AddFieldNodes(Func<InventoryShipmentLineItemQueryBuilder, InventoryShipmentLineItemQueryBuilder> build)
    {
        AddField<InventoryShipmentLineItem, InventoryShipmentLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public InventoryShipmentLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}