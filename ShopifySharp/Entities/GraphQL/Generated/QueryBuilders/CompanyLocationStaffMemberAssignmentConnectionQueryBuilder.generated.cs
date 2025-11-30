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

public class CompanyLocationStaffMemberAssignmentConnectionQueryBuilder() : GraphQueryBuilder<CompanyLocationStaffMemberAssignmentConnection>("companyLocationStaffMemberAssignmentConnection")
{
    public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder AddFieldEdges(Func<CompanyLocationStaffMemberAssignmentEdgeQueryBuilder, CompanyLocationStaffMemberAssignmentEdgeQueryBuilder> build)
    {
        AddField<CompanyLocationStaffMemberAssignmentEdge, CompanyLocationStaffMemberAssignmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder AddFieldNodes(Func<CompanyLocationStaffMemberAssignmentQueryBuilder, CompanyLocationStaffMemberAssignmentQueryBuilder> build)
    {
        AddField<CompanyLocationStaffMemberAssignment, CompanyLocationStaffMemberAssignmentQueryBuilder>("nodes", build);
        return this;
    }

    public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}