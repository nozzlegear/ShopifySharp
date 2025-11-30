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

public class InventoryShipmentCreateInTransitPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentCreateInTransitPayload>("inventoryShipmentCreateInTransitPayload")
{
    public InventoryShipmentCreateInTransitPayloadQueryBuilder AddFieldInventoryShipment(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("inventoryShipment", build);
        return this;
    }

    public InventoryShipmentCreateInTransitPayloadQueryBuilder AddFieldUserErrors(Func<InventoryShipmentCreateInTransitUserErrorQueryBuilder, InventoryShipmentCreateInTransitUserErrorQueryBuilder> build)
    {
        AddField<InventoryShipmentCreateInTransitUserError, InventoryShipmentCreateInTransitUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}