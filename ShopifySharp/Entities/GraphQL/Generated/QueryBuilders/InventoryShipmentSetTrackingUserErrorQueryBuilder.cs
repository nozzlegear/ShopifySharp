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

public class InventoryShipmentSetTrackingUserErrorQueryBuilder() : GraphQueryBuilder<InventoryShipmentSetTrackingUserError>("query inventoryShipmentSetTrackingUserError")
{
    public InventoryShipmentSetTrackingUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryShipmentSetTrackingUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryShipmentSetTrackingUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}