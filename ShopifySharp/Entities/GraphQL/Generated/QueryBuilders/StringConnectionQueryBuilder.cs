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

public class StringConnectionQueryBuilder() : GraphQueryBuilder<StringConnection>("query stringConnection")
{
    public StringConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public StringConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public StringConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}