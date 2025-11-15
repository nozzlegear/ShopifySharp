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

public class InventoryItemUpdatePayloadQueryBuilder() : GraphQueryBuilder<InventoryItemUpdatePayload>("query inventoryItemUpdatePayload")
{
    public InventoryItemUpdatePayloadQueryBuilder AddFieldInventoryItem()
    {
        AddField("inventoryItem");
        return this;
    }

    public InventoryItemUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}