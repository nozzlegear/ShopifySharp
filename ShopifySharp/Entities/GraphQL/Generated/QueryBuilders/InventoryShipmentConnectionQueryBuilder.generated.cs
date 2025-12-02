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

public class InventoryShipmentConnectionQueryBuilder() : GraphQueryBuilder<InventoryShipmentConnection>("inventoryShipmentConnection")
{
    public InventoryShipmentConnectionQueryBuilder AddFieldEdges(Func<InventoryShipmentEdgeQueryBuilder, InventoryShipmentEdgeQueryBuilder> build)
    {
        AddField<InventoryShipmentEdge, InventoryShipmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public InventoryShipmentConnectionQueryBuilder AddFieldNodes(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("nodes", build);
        return this;
    }

    public InventoryShipmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}