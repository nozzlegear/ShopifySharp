#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class AppleApplicationQueryBuilder() : GraphQueryBuilder<AppleApplication>("query appleApplication")
{
    public AppleApplicationQueryBuilder AddFieldAppClipApplicationId()
    {
        AddField("appClipApplicationId");
        return this;
    }

    public AppleApplicationQueryBuilder AddFieldAppClipsEnabled()
    {
        AddField("appClipsEnabled");
        return this;
    }

    public AppleApplicationQueryBuilder AddFieldAppId()
    {
        AddField("appId");
        return this;
    }

    public AppleApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppleApplicationQueryBuilder AddFieldSharedWebCredentialsEnabled()
    {
        AddField("sharedWebCredentialsEnabled");
        return this;
    }

    public AppleApplicationQueryBuilder AddFieldUniversalLinksEnabled()
    {
        AddField("universalLinksEnabled");
        return this;
    }
}