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

public class LocalizedFieldConnectionQueryBuilder() : GraphQueryBuilder<LocalizedFieldConnection>("query localizedFieldConnection")
{
    public LocalizedFieldConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public LocalizedFieldConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public LocalizedFieldConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}