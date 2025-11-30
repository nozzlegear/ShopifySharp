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

public class InventorySetQuantitiesUserErrorQueryBuilder() : GraphQueryBuilder<InventorySetQuantitiesUserError>("query inventorySetQuantitiesUserError")
{
    public InventorySetQuantitiesUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventorySetQuantitiesUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventorySetQuantitiesUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}