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

public class SearchResultConnectionQueryBuilder() : GraphQueryBuilder<SearchResultConnection>("searchResultConnection")
{
    public SearchResultConnectionQueryBuilder AddFieldEdges(Func<SearchResultEdgeQueryBuilder, SearchResultEdgeQueryBuilder> build)
    {
        AddField<SearchResultEdge, SearchResultEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SearchResultConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }

    [Obsolete("The provided information is not accurate.")]
    public SearchResultConnectionQueryBuilder AddFieldResultsAfterCount()
    {
        AddField("resultsAfterCount");
        return this;
    }
}