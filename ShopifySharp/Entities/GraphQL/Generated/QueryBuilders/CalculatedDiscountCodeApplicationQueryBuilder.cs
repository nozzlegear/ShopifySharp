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

public class CalculatedDiscountCodeApplicationQueryBuilder() : GraphQueryBuilder<CalculatedDiscountCodeApplication>("query calculatedDiscountCodeApplication")
{
    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldAppliedTo()
    {
        AddField("appliedTo");
        return this;
    }

    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public CalculatedDiscountCodeApplicationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}