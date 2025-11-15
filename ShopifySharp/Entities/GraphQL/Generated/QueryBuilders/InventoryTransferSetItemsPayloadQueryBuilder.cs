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

public class InventoryTransferSetItemsPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferSetItemsPayload>("query inventoryTransferSetItemsPayload")
{
    public InventoryTransferSetItemsPayloadQueryBuilder AddFieldInventoryTransfer()
    {
        AddField("inventoryTransfer");
        return this;
    }

    public InventoryTransferSetItemsPayloadQueryBuilder AddFieldUpdatedLineItems()
    {
        AddField("updatedLineItems");
        return this;
    }

    public InventoryTransferSetItemsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}