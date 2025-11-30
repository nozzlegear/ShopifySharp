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

public class InventoryTransferRemoveItemsPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferRemoveItemsPayload>("query inventoryTransferRemoveItemsPayload")
{
    public InventoryTransferRemoveItemsPayloadQueryBuilder AddFieldInventoryTransfer()
    {
        AddField("inventoryTransfer");
        return this;
    }

    public InventoryTransferRemoveItemsPayloadQueryBuilder AddFieldRemovedQuantities()
    {
        AddField("removedQuantities");
        return this;
    }

    public InventoryTransferRemoveItemsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}