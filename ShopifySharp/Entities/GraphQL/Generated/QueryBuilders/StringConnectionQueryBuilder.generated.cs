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

public class StringConnectionQueryBuilder() : GraphQueryBuilder<StringConnection>("stringConnection")
{
    public StringConnectionQueryBuilder AddFieldEdges(Func<StringEdgeQueryBuilder, StringEdgeQueryBuilder> build)
    {
        AddField<StringEdge, StringEdgeQueryBuilder>("edges", build);
        return this;
    }

    public StringConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public StringConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}