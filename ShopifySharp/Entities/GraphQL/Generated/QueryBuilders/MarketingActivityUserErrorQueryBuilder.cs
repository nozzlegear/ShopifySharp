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

public class MarketingActivityUserErrorQueryBuilder() : GraphQueryBuilder<MarketingActivityUserError>("query marketingActivityUserError")
{
    public MarketingActivityUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MarketingActivityUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MarketingActivityUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}