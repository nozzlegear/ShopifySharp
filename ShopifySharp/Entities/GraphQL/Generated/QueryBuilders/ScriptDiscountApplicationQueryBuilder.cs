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

public class ScriptDiscountApplicationQueryBuilder() : GraphQueryBuilder<ScriptDiscountApplication>("query scriptDiscountApplication")
{
    public ScriptDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    [Obsolete("Use `title` instead.")]
    public ScriptDiscountApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public ScriptDiscountApplicationQueryBuilder AddFieldIndex()
    {
        AddField("index");
        return this;
    }

    public ScriptDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public ScriptDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public ScriptDiscountApplicationQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ScriptDiscountApplicationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}