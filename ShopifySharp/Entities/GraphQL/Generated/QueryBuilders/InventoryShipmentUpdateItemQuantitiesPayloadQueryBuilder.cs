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

public class InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentUpdateItemQuantitiesPayload>("query inventoryShipmentUpdateItemQuantitiesPayload")
{
    public InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder AddFieldShipment()
    {
        AddField("shipment");
        return this;
    }

    public InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder AddFieldUpdatedLineItems()
    {
        AddField("updatedLineItems");
        return this;
    }

    public InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}