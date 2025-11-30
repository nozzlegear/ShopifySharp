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

public class StorefrontAccessTokenConnectionQueryBuilder() : GraphQueryBuilder<StorefrontAccessTokenConnection>("storefrontAccessTokenConnection")
{
    public StorefrontAccessTokenConnectionQueryBuilder AddFieldEdges(Func<StorefrontAccessTokenEdgeQueryBuilder, StorefrontAccessTokenEdgeQueryBuilder> build)
    {
        AddField<StorefrontAccessTokenEdge, StorefrontAccessTokenEdgeQueryBuilder>("edges", build);
        return this;
    }

    public StorefrontAccessTokenConnectionQueryBuilder AddFieldNodes(Func<StorefrontAccessTokenQueryBuilder, StorefrontAccessTokenQueryBuilder> build)
    {
        AddField<StorefrontAccessToken, StorefrontAccessTokenQueryBuilder>("nodes", build);
        return this;
    }

    public StorefrontAccessTokenConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}