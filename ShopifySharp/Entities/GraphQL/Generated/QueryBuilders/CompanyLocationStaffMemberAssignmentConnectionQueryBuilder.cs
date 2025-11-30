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

public class CompanyLocationStaffMemberAssignmentConnectionQueryBuilder() : GraphQueryBuilder<CompanyLocationStaffMemberAssignmentConnection>("query companyLocationStaffMemberAssignmentConnection")
{
    public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}