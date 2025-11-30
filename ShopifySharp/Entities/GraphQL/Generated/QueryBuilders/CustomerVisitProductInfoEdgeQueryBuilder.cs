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

public class CustomerVisitProductInfoEdgeQueryBuilder() : GraphQueryBuilder<CustomerVisitProductInfoEdge>("query customerVisitProductInfoEdge")
{
    public CustomerVisitProductInfoEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CustomerVisitProductInfoEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}