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

public class CompanyContactRoleEdgeQueryBuilder() : GraphQueryBuilder<CompanyContactRoleEdge>("query companyContactRoleEdge")
{
    public CompanyContactRoleEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CompanyContactRoleEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}