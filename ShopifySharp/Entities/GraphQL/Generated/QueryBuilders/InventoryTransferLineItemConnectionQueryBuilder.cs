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

public class InventoryTransferLineItemConnectionQueryBuilder() : GraphQueryBuilder<InventoryTransferLineItemConnection>("query inventoryTransferLineItemConnection")
{
    public InventoryTransferLineItemConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public InventoryTransferLineItemConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public InventoryTransferLineItemConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}