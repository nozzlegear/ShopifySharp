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

[Obsolete("Use `inventorySetQuantities` to set on_hand or available quantites instead.")]
public class InventorySetOnHandQuantitiesQueryBuilder() : GraphQueryBuilder<InventorySetOnHandQuantitiesPayload>("query inventorySetOnHandQuantities")
{
    public InventorySetOnHandQuantitiesQueryBuilder AddArgumentInput(InventorySetOnHandQuantitiesInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}