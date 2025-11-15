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

public class InventoryShipmentMarkInTransitUserErrorQueryBuilder() : GraphQueryBuilder<InventoryShipmentMarkInTransitUserError>("query inventoryShipmentMarkInTransitUserError")
{
    public InventoryShipmentMarkInTransitUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryShipmentMarkInTransitUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryShipmentMarkInTransitUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}