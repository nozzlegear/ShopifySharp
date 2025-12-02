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

public class MarketLocalizableContentQueryBuilder() : GraphQueryBuilder<MarketLocalizableContent>("marketLocalizableContent")
{
    public MarketLocalizableContentQueryBuilder AddFieldDigest()
    {
        AddField("digest");
        return this;
    }

    public MarketLocalizableContentQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MarketLocalizableContentQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}