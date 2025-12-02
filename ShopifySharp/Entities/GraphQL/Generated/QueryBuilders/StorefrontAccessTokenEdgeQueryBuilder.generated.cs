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

public class StorefrontAccessTokenEdgeQueryBuilder() : GraphQueryBuilder<StorefrontAccessTokenEdge>("storefrontAccessTokenEdge")
{
    public StorefrontAccessTokenEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public StorefrontAccessTokenEdgeQueryBuilder AddFieldNode(Func<StorefrontAccessTokenQueryBuilder, StorefrontAccessTokenQueryBuilder> build)
    {
        AddField<StorefrontAccessToken, StorefrontAccessTokenQueryBuilder>("node", build);
        return this;
    }
}