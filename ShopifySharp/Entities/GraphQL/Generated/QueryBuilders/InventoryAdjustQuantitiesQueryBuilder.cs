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

public class InventoryAdjustQuantitiesQueryBuilder() : GraphQueryBuilder<InventoryAdjustQuantitiesPayload>("query inventoryAdjustQuantities")
{
    public InventoryAdjustQuantitiesQueryBuilder AddArgumentInput(InventoryAdjustQuantitiesInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}