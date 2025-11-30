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

public class InventoryLevelConnectionQueryBuilder() : GraphQueryBuilder<InventoryLevelConnection>("query inventoryLevelConnection")
{
    public InventoryLevelConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public InventoryLevelConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public InventoryLevelConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}