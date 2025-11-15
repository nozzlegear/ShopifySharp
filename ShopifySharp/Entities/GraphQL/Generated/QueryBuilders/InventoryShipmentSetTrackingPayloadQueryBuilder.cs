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

public class InventoryShipmentSetTrackingPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentSetTrackingPayload>("query inventoryShipmentSetTrackingPayload")
{
    public InventoryShipmentSetTrackingPayloadQueryBuilder AddFieldInventoryShipment()
    {
        AddField("inventoryShipment");
        return this;
    }

    public InventoryShipmentSetTrackingPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}