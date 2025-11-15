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

public class IDiscountApplicationQueryBuilder() : GraphQueryBuilder<IDiscountApplication>("query iDiscountApplication")
{
    public IDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public IDiscountApplicationQueryBuilder AddFieldIndex()
    {
        AddField("index");
        return this;
    }

    public IDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public IDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public IDiscountApplicationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}