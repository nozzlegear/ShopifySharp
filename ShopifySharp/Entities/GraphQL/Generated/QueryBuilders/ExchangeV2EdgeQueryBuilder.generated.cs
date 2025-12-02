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

public class ExchangeV2EdgeQueryBuilder() : GraphQueryBuilder<ExchangeV2Edge>("exchangeV2Edge")
{
    public ExchangeV2EdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ExchangeV2EdgeQueryBuilder AddFieldNode(Func<ExchangeV2QueryBuilder, ExchangeV2QueryBuilder> build)
    {
        AddField<ExchangeV2, ExchangeV2QueryBuilder>("node", build);
        return this;
    }
}