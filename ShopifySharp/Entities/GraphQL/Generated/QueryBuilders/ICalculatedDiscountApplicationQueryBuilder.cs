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

public class ICalculatedDiscountApplicationQueryBuilder() : GraphQueryBuilder<ICalculatedDiscountApplication>("query iCalculatedDiscountApplication")
{
    public ICalculatedDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public ICalculatedDiscountApplicationQueryBuilder AddFieldAppliedTo()
    {
        AddField("appliedTo");
        return this;
    }

    public ICalculatedDiscountApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public ICalculatedDiscountApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ICalculatedDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public ICalculatedDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public ICalculatedDiscountApplicationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}