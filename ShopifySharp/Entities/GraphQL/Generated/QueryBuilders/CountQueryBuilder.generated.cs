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

public class CountQueryBuilder() : GraphQueryBuilder<Count>("count")
{
    public CountQueryBuilder AddFieldCount()
    {
        AddField("count");
        return this;
    }

    public CountQueryBuilder AddFieldPrecision()
    {
        AddField("precision");
        return this;
    }
}