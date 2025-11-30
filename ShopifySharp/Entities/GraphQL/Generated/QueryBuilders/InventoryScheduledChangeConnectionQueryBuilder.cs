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

public class InventoryScheduledChangeConnectionQueryBuilder() : GraphQueryBuilder<InventoryScheduledChangeConnection>("query inventoryScheduledChangeConnection")
{
    public InventoryScheduledChangeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public InventoryScheduledChangeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public InventoryScheduledChangeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}