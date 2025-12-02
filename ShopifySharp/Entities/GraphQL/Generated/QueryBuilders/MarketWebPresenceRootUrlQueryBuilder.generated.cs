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

public class MarketWebPresenceRootUrlQueryBuilder() : GraphQueryBuilder<MarketWebPresenceRootUrl>("marketWebPresenceRootUrl")
{
    public MarketWebPresenceRootUrlQueryBuilder AddFieldLocale()
    {
        AddField("locale");
        return this;
    }

    public MarketWebPresenceRootUrlQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}