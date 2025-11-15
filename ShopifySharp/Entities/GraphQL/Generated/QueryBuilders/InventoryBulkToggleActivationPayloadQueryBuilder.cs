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

public class InventoryBulkToggleActivationPayloadQueryBuilder() : GraphQueryBuilder<InventoryBulkToggleActivationPayload>("query inventoryBulkToggleActivationPayload")
{
    public InventoryBulkToggleActivationPayloadQueryBuilder AddFieldInventoryItem()
    {
        AddField("inventoryItem");
        return this;
    }

    public InventoryBulkToggleActivationPayloadQueryBuilder AddFieldInventoryLevels()
    {
        AddField("inventoryLevels");
        return this;
    }

    public InventoryBulkToggleActivationPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}