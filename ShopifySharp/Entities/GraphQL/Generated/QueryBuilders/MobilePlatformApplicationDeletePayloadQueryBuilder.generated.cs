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

public class MobilePlatformApplicationDeletePayloadQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationDeletePayload>("mobilePlatformApplicationDeletePayload")
{
    public MobilePlatformApplicationDeletePayloadQueryBuilder AddFieldDeletedMobilePlatformApplicationId()
    {
        AddField("deletedMobilePlatformApplicationId");
        return this;
    }

    public MobilePlatformApplicationDeletePayloadQueryBuilder AddFieldUserErrors(Func<MobilePlatformApplicationUserErrorQueryBuilder, MobilePlatformApplicationUserErrorQueryBuilder> build)
    {
        AddField<MobilePlatformApplicationUserError, MobilePlatformApplicationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}