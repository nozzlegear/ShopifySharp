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

public class OnlineStoreThemeFileConnectionQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFileConnection>("query onlineStoreThemeFileConnection")
{
    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }

    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}