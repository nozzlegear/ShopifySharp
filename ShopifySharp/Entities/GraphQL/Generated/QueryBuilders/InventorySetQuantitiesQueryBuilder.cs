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

public class InventorySetQuantitiesQueryBuilder() : GraphQueryBuilder<InventorySetQuantitiesPayload>("query inventorySetQuantities")
{
    public InventorySetQuantitiesQueryBuilder AddArgumentInput(InventorySetQuantitiesInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}