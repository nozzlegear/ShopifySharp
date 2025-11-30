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

public class MobilePlatformApplicationUserErrorQueryBuilder() : GraphQueryBuilder<MobilePlatformApplicationUserError>("mobilePlatformApplicationUserError")
{
    public MobilePlatformApplicationUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MobilePlatformApplicationUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MobilePlatformApplicationUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}