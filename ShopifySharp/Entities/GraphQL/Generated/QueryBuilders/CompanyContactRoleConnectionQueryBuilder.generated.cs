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

public class CompanyContactRoleConnectionQueryBuilder() : GraphQueryBuilder<CompanyContactRoleConnection>("companyContactRoleConnection")
{
    public CompanyContactRoleConnectionQueryBuilder AddFieldEdges(Func<CompanyContactRoleEdgeQueryBuilder, CompanyContactRoleEdgeQueryBuilder> build)
    {
        AddField<CompanyContactRoleEdge, CompanyContactRoleEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CompanyContactRoleConnectionQueryBuilder AddFieldNodes(Func<CompanyContactRoleQueryBuilder, CompanyContactRoleQueryBuilder> build)
    {
        AddField<CompanyContactRole, CompanyContactRoleQueryBuilder>("nodes", build);
        return this;
    }

    public CompanyContactRoleConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}