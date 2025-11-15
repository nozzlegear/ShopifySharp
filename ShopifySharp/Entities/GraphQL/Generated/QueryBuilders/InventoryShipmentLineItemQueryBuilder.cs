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

public class InventoryShipmentLineItemQueryBuilder() : GraphQueryBuilder<InventoryShipmentLineItem>("query inventoryShipmentLineItem")
{
    public InventoryShipmentLineItemQueryBuilder AddFieldAcceptedQuantity()
    {
        AddField("acceptedQuantity");
        return this;
    }

    public InventoryShipmentLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public InventoryShipmentLineItemQueryBuilder AddFieldInventoryItem()
    {
        AddField("inventoryItem");
        return this;
    }

    public InventoryShipmentLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public InventoryShipmentLineItemQueryBuilder AddFieldRejectedQuantity()
    {
        AddField("rejectedQuantity");
        return this;
    }

    public InventoryShipmentLineItemQueryBuilder AddFieldUnreceivedQuantity()
    {
        AddField("unreceivedQuantity");
        return this;
    }
}