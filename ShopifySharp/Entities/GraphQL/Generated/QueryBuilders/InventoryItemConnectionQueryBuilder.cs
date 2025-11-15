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

public class InventoryItemConnectionQueryBuilder() : GraphQueryBuilder<InventoryItemConnection>("query inventoryItemConnection")
{
    public InventoryItemConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public InventoryItemConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public InventoryItemConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}