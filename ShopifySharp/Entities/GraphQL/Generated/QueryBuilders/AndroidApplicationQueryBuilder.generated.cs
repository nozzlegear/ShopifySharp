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

public class AndroidApplicationQueryBuilder() : GraphQueryBuilder<AndroidApplication>("androidApplication")
{
    public AndroidApplicationQueryBuilder AddFieldApplicationId()
    {
        AddField("applicationId");
        return this;
    }

    public AndroidApplicationQueryBuilder AddFieldAppLinksEnabled()
    {
        AddField("appLinksEnabled");
        return this;
    }

    public AndroidApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AndroidApplicationQueryBuilder AddFieldSha256CertFingerprints()
    {
        AddField("sha256CertFingerprints");
        return this;
    }
}