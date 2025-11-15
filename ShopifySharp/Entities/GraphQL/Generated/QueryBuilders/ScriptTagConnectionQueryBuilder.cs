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

public class ScriptTagConnectionQueryBuilder() : GraphQueryBuilder<ScriptTagConnection>("query scriptTagConnection")
{
    public ScriptTagConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ScriptTagConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ScriptTagConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}