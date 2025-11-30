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

public class InventoryTransferLineItemQueryBuilder() : GraphQueryBuilder<InventoryTransferLineItem>("query inventoryTransferLineItem")
{
    public InventoryTransferLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public InventoryTransferLineItemQueryBuilder AddFieldInventoryItem()
    {
        AddField("inventoryItem");
        return this;
    }

    public InventoryTransferLineItemQueryBuilder AddFieldPickedForShipmentQuantity()
    {
        AddField("pickedForShipmentQuantity");
        return this;
    }

    public InventoryTransferLineItemQueryBuilder AddFieldProcessableQuantity()
    {
        AddField("processableQuantity");
        return this;
    }

    public InventoryTransferLineItemQueryBuilder AddFieldShippableQuantity()
    {
        AddField("shippableQuantity");
        return this;
    }

    public InventoryTransferLineItemQueryBuilder AddFieldShippedQuantity()
    {
        AddField("shippedQuantity");
        return this;
    }

    public InventoryTransferLineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public InventoryTransferLineItemQueryBuilder AddFieldTotalQuantity()
    {
        AddField("totalQuantity");
        return this;
    }
}