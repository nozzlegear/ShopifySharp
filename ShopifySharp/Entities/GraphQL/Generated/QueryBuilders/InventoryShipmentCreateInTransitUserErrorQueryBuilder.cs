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

public class InventoryShipmentCreateInTransitUserErrorQueryBuilder() : GraphQueryBuilder<InventoryShipmentCreateInTransitUserError>("query inventoryShipmentCreateInTransitUserError")
{
    public InventoryShipmentCreateInTransitUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryShipmentCreateInTransitUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryShipmentCreateInTransitUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}