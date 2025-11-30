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

public class CompanyContactRoleAssignmentEdgeQueryBuilder() : GraphQueryBuilder<CompanyContactRoleAssignmentEdge>("companyContactRoleAssignmentEdge")
{
    public CompanyContactRoleAssignmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CompanyContactRoleAssignmentEdgeQueryBuilder AddFieldNode(Func<CompanyContactRoleAssignmentQueryBuilder, CompanyContactRoleAssignmentQueryBuilder> build)
    {
        AddField<CompanyContactRoleAssignment, CompanyContactRoleAssignmentQueryBuilder>("node", build);
        return this;
    }
}