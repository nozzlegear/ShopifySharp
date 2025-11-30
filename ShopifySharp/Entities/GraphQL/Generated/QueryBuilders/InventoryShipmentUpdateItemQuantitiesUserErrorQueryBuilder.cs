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

public class InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder() : GraphQueryBuilder<InventoryShipmentUpdateItemQuantitiesUserError>("query inventoryShipmentUpdateItemQuantitiesUserError")
{
    public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}