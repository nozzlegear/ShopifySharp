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

public class CompanyContactRoleAssignmentConnectionQueryBuilder() : GraphQueryBuilder<CompanyContactRoleAssignmentConnection>("companyContactRoleAssignmentConnection")
{
    public CompanyContactRoleAssignmentConnectionQueryBuilder AddFieldEdges(Func<CompanyContactRoleAssignmentEdgeQueryBuilder, CompanyContactRoleAssignmentEdgeQueryBuilder> build)
    {
        AddField<CompanyContactRoleAssignmentEdge, CompanyContactRoleAssignmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CompanyContactRoleAssignmentConnectionQueryBuilder AddFieldNodes(Func<CompanyContactRoleAssignmentQueryBuilder, CompanyContactRoleAssignmentQueryBuilder> build)
    {
        AddField<CompanyContactRoleAssignment, CompanyContactRoleAssignmentQueryBuilder>("nodes", build);
        return this;
    }

    public CompanyContactRoleAssignmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}