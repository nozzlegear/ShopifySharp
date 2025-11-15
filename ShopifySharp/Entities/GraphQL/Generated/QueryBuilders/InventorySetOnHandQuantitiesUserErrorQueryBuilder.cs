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

public class InventorySetOnHandQuantitiesUserErrorQueryBuilder() : GraphQueryBuilder<InventorySetOnHandQuantitiesUserError>("query inventorySetOnHandQuantitiesUserError")
{
    public InventorySetOnHandQuantitiesUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventorySetOnHandQuantitiesUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventorySetOnHandQuantitiesUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}