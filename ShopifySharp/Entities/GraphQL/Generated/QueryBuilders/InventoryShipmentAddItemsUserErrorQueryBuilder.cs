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

public class InventoryShipmentAddItemsUserErrorQueryBuilder() : GraphQueryBuilder<InventoryShipmentAddItemsUserError>("query inventoryShipmentAddItemsUserError")
{
    public InventoryShipmentAddItemsUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryShipmentAddItemsUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryShipmentAddItemsUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}