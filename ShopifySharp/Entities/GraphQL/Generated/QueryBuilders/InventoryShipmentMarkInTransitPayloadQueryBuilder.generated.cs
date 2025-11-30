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

public class InventoryShipmentMarkInTransitPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentMarkInTransitPayload>("inventoryShipmentMarkInTransitPayload")
{
    public InventoryShipmentMarkInTransitPayloadQueryBuilder AddFieldInventoryShipment(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("inventoryShipment", build);
        return this;
    }

    public InventoryShipmentMarkInTransitPayloadQueryBuilder AddFieldUserErrors(Func<InventoryShipmentMarkInTransitUserErrorQueryBuilder, InventoryShipmentMarkInTransitUserErrorQueryBuilder> build)
    {
        AddField<InventoryShipmentMarkInTransitUserError, InventoryShipmentMarkInTransitUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}