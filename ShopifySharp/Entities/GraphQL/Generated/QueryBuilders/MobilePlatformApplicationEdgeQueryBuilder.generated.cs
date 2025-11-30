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

public class MobilePlatformApplicationEdgeQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationEdge>("mobilePlatformApplicationEdge")
{
    public MobilePlatformApplicationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MobilePlatformApplicationEdgeQueryBuilder AddUnionCaseNode(Func<AndroidApplicationQueryBuilder, AndroidApplicationQueryBuilder> build)
    {
        AddUnion<AndroidApplication, AndroidApplicationQueryBuilder>("node", build);
        return this;
    }

    public MobilePlatformApplicationEdgeQueryBuilder AddUnionCaseNode(Func<AppleApplicationQueryBuilder, AppleApplicationQueryBuilder> build)
    {
        AddUnion<AppleApplication, AppleApplicationQueryBuilder>("node", build);
        return this;
    }
}