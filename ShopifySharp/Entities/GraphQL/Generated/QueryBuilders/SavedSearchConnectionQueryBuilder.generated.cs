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

public class SavedSearchConnectionQueryBuilder() : GraphQueryBuilder<SavedSearchConnection>("savedSearchConnection")
{
    public SavedSearchConnectionQueryBuilder AddFieldEdges(Func<SavedSearchEdgeQueryBuilder, SavedSearchEdgeQueryBuilder> build)
    {
        AddField<SavedSearchEdge, SavedSearchEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SavedSearchConnectionQueryBuilder AddFieldNodes(Func<SavedSearchQueryBuilder, SavedSearchQueryBuilder> build)
    {
        AddField<SavedSearch, SavedSearchQueryBuilder>("nodes", build);
        return this;
    }

    public SavedSearchConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}