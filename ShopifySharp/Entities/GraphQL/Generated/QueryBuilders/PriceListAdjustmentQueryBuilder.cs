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

public class PriceListAdjustmentQueryBuilder() : GraphQueryBuilder<PriceListAdjustment>("query priceListAdjustment")
{
    public PriceListAdjustmentQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public PriceListAdjustmentQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}