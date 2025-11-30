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

public class CompanyLocationEdgeQueryBuilder() : GraphQueryBuilder<CompanyLocationEdge>("query companyLocationEdge")
{
    public CompanyLocationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CompanyLocationEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}