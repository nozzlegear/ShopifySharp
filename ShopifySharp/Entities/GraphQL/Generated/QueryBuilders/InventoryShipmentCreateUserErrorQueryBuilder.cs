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

public class InventoryShipmentCreateUserErrorQueryBuilder() : GraphQueryBuilder<InventoryShipmentCreateUserError>("query inventoryShipmentCreateUserError")
{
    public InventoryShipmentCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryShipmentCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryShipmentCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}