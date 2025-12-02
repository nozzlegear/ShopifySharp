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

public class CompanyContactRoleEdgeQueryBuilder() : GraphQueryBuilder<CompanyContactRoleEdge>("companyContactRoleEdge")
{
    public CompanyContactRoleEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CompanyContactRoleEdgeQueryBuilder AddFieldNode(Func<CompanyContactRoleQueryBuilder, CompanyContactRoleQueryBuilder> build)
    {
        AddField<CompanyContactRole, CompanyContactRoleQueryBuilder>("node", build);
        return this;
    }
}