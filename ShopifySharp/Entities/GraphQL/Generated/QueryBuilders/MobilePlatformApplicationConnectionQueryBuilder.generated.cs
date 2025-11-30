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

public class MobilePlatformApplicationConnectionQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationConnection>("mobilePlatformApplicationConnection")
{
    public MobilePlatformApplicationConnectionQueryBuilder AddFieldEdges(Func<MobilePlatformApplicationEdgeQueryBuilder, MobilePlatformApplicationEdgeQueryBuilder> build)
    {
        AddField<MobilePlatformApplicationEdge, MobilePlatformApplicationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MobilePlatformApplicationConnectionQueryBuilder AddUnionCaseNodes(Func<AndroidApplicationQueryBuilder, AndroidApplicationQueryBuilder> build)
    {
        AddUnion<AndroidApplication, AndroidApplicationQueryBuilder>("nodes", build);
        return this;
    }

    public MobilePlatformApplicationConnectionQueryBuilder AddUnionCaseNodes(Func<AppleApplicationQueryBuilder, AppleApplicationQueryBuilder> build)
    {
        AddUnion<AppleApplication, AppleApplicationQueryBuilder>("nodes", build);
        return this;
    }

    public MobilePlatformApplicationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}