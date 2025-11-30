#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class InventoryShipmentCreateInTransitPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentCreateInTransitPayload>("query inventoryShipmentCreateInTransitPayload")
{
    public InventoryShipmentCreateInTransitPayloadQueryBuilder AddFieldInventoryShipment()
    {
        AddField("inventoryShipment");
        return this;
    }

    public InventoryShipmentCreateInTransitPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}