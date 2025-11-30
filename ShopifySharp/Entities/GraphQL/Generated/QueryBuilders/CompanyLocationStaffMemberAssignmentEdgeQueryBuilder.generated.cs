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

public class CompanyLocationStaffMemberAssignmentEdgeQueryBuilder() : GraphQueryBuilder<CompanyLocationStaffMemberAssignmentEdge>("companyLocationStaffMemberAssignmentEdge")
{
    public CompanyLocationStaffMemberAssignmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CompanyLocationStaffMemberAssignmentEdgeQueryBuilder AddFieldNode(Func<CompanyLocationStaffMemberAssignmentQueryBuilder, CompanyLocationStaffMemberAssignmentQueryBuilder> build)
    {
        AddField<CompanyLocationStaffMemberAssignment, CompanyLocationStaffMemberAssignmentQueryBuilder>("node", build);
        return this;
    }
}