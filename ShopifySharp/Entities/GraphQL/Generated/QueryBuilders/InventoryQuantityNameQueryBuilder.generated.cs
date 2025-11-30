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

public class InventoryQuantityNameQueryBuilder() : GraphQueryBuilder<InventoryQuantityName>("inventoryQuantityName")
{
    public InventoryQuantityNameQueryBuilder AddFieldBelongsTo()
    {
        AddField("belongsTo");
        return this;
    }

    public InventoryQuantityNameQueryBuilder AddFieldComprises()
    {
        AddField("comprises");
        return this;
    }

    public InventoryQuantityNameQueryBuilder AddFieldDisplayName()
    {
        AddField("displayName");
        return this;
    }

    public InventoryQuantityNameQueryBuilder AddFieldIsInUse()
    {
        AddField("isInUse");
        return this;
    }

    public InventoryQuantityNameQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}