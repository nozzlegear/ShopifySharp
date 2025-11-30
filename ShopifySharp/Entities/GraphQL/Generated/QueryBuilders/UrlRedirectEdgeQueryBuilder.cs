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

public class UrlRedirectEdgeQueryBuilder() : GraphQueryBuilder<UrlRedirectEdge>("query urlRedirectEdge")
{
    public UrlRedirectEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public UrlRedirectEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}