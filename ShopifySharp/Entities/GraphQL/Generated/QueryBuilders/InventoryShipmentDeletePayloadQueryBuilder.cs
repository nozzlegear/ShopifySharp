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

public class InventoryShipmentDeletePayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentDeletePayload>("query inventoryShipmentDeletePayload")
{
    public InventoryShipmentDeletePayloadQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public InventoryShipmentDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}