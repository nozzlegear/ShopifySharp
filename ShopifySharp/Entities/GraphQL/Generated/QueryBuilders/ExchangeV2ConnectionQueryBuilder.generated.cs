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

public class ExchangeV2ConnectionQueryBuilder() : GraphQueryBuilder<ExchangeV2Connection>("exchangeV2Connection")
{
    public ExchangeV2ConnectionQueryBuilder AddFieldEdges(Func<ExchangeV2EdgeQueryBuilder, ExchangeV2EdgeQueryBuilder> build)
    {
        AddField<ExchangeV2Edge, ExchangeV2EdgeQueryBuilder>("edges", build);
        return this;
    }

    public ExchangeV2ConnectionQueryBuilder AddFieldNodes(Func<ExchangeV2QueryBuilder, ExchangeV2QueryBuilder> build)
    {
        AddField<ExchangeV2, ExchangeV2QueryBuilder>("nodes", build);
        return this;
    }

    public ExchangeV2ConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}