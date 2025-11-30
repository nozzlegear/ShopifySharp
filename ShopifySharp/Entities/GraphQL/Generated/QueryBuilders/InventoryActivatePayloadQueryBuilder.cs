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

public class InventoryActivatePayloadQueryBuilder() : GraphQueryBuilder<InventoryActivatePayload>("query inventoryActivatePayload")
{
    public InventoryActivatePayloadQueryBuilder AddFieldInventoryLevel()
    {
        AddField("inventoryLevel");
        return this;
    }

    public InventoryActivatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}