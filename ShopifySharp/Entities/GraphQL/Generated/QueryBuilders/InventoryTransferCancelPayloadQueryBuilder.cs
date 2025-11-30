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

public class InventoryTransferCancelPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferCancelPayload>("query inventoryTransferCancelPayload")
{
    public InventoryTransferCancelPayloadQueryBuilder AddFieldInventoryTransfer()
    {
        AddField("inventoryTransfer");
        return this;
    }

    public InventoryTransferCancelPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}