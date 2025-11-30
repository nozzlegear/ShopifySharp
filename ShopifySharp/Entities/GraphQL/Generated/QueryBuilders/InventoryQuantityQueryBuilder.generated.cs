#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class InventoryQuantityQueryBuilder() : GraphQueryBuilder<InventoryQuantity>("inventoryQuantity")
{
    public InventoryQuantityQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public InventoryQuantityQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public InventoryQuantityQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public InventoryQuantityQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}