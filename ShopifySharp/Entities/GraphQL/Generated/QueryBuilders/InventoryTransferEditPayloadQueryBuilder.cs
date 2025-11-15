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

public class InventoryTransferEditPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferEditPayload>("query inventoryTransferEditPayload")
{
    public InventoryTransferEditPayloadQueryBuilder AddFieldInventoryTransfer()
    {
        AddField("inventoryTransfer");
        return this;
    }

    public InventoryTransferEditPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}