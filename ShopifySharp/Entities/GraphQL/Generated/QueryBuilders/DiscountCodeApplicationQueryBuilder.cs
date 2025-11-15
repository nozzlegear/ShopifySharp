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

public class DiscountCodeApplicationQueryBuilder() : GraphQueryBuilder<DiscountCodeApplication>("query discountCodeApplication")
{
    public DiscountCodeApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public DiscountCodeApplicationQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DiscountCodeApplicationQueryBuilder AddFieldIndex()
    {
        AddField("index");
        return this;
    }

    public DiscountCodeApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public DiscountCodeApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public DiscountCodeApplicationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}