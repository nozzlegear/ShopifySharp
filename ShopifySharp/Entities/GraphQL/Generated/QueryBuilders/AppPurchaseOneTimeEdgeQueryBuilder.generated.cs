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

public class AppPurchaseOneTimeEdgeQueryBuilder() : GraphQueryBuilder<AppPurchaseOneTimeEdge>("appPurchaseOneTimeEdge")
{
    public AppPurchaseOneTimeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AppPurchaseOneTimeEdgeQueryBuilder AddFieldNode(Func<AppPurchaseOneTimeQueryBuilder, AppPurchaseOneTimeQueryBuilder> build)
    {
        AddField<AppPurchaseOneTime, AppPurchaseOneTimeQueryBuilder>("node", build);
        return this;
    }
}