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

public class MobilePlatformApplicationCreatePayloadQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationCreatePayload>("mobilePlatformApplicationCreatePayload")
{
    public MobilePlatformApplicationCreatePayloadQueryBuilder AddUnionCaseMobilePlatformApplication(Func<AndroidApplicationQueryBuilder, AndroidApplicationQueryBuilder> build)
    {
        AddUnion<AndroidApplication, AndroidApplicationQueryBuilder>("mobilePlatformApplication", build);
        return this;
    }

    public MobilePlatformApplicationCreatePayloadQueryBuilder AddUnionCaseMobilePlatformApplication(Func<AppleApplicationQueryBuilder, AppleApplicationQueryBuilder> build)
    {
        AddUnion<AppleApplication, AppleApplicationQueryBuilder>("mobilePlatformApplication", build);
        return this;
    }

    public MobilePlatformApplicationCreatePayloadQueryBuilder AddFieldUserErrors(Func<MobilePlatformApplicationUserErrorQueryBuilder, MobilePlatformApplicationUserErrorQueryBuilder> build)
    {
        AddField<MobilePlatformApplicationUserError, MobilePlatformApplicationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}