#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class InventoryShipmentLineItemQueryBuilder() : GraphQueryBuilder<InventoryShipmentLineItem>("inventoryShipmentLineItem")
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

    public InventoryShipmentLineItemQueryBuilder AddFieldInventoryItem(Func<InventoryItemQueryBuilder, InventoryItemQueryBuilder> build)
    {
        AddField<InventoryItem, InventoryItemQueryBuilder>("inventoryItem", build);
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