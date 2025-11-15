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

public class InventorySetScheduledChangesPayloadQueryBuilder() : GraphQueryBuilder<InventorySetScheduledChangesPayload>("query inventorySetScheduledChangesPayload")
{
    public InventorySetScheduledChangesPayloadQueryBuilder AddFieldScheduledChanges()
    {
        AddField("scheduledChanges");
        return this;
    }

    public InventorySetScheduledChangesPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}