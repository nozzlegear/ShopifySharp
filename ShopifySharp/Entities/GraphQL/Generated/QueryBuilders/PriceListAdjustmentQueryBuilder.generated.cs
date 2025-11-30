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

public class PriceListAdjustmentQueryBuilder() : GraphQueryBuilder<PriceListAdjustment>("priceListAdjustment")
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