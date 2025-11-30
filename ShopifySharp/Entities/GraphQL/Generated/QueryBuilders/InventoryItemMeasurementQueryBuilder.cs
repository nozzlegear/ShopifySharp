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

public class InventoryItemMeasurementQueryBuilder() : GraphQueryBuilder<InventoryItemMeasurement>("query inventoryItemMeasurement")
{
    public InventoryItemMeasurementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public InventoryItemMeasurementQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}