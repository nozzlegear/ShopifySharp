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

public class UrlRedirectConnectionQueryBuilder() : GraphQueryBuilder<UrlRedirectConnection>("query urlRedirectConnection")
{
    public UrlRedirectConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public UrlRedirectConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public UrlRedirectConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}