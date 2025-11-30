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

public class CombinedListingChildConnectionQueryBuilder() : GraphQueryBuilder<CombinedListingChildConnection>("combinedListingChildConnection")
{
    public CombinedListingChildConnectionQueryBuilder AddFieldEdges(Func<CombinedListingChildEdgeQueryBuilder, CombinedListingChildEdgeQueryBuilder> build)
    {
        AddField<CombinedListingChildEdge, CombinedListingChildEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CombinedListingChildConnectionQueryBuilder AddFieldNodes(Func<CombinedListingChildQueryBuilder, CombinedListingChildQueryBuilder> build)
    {
        AddField<CombinedListingChild, CombinedListingChildQueryBuilder>("nodes", build);
        return this;
    }

    public CombinedListingChildConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}