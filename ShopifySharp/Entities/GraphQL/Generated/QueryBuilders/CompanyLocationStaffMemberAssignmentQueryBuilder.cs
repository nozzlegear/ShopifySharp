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

public class CompanyLocationStaffMemberAssignmentQueryBuilder() : GraphQueryBuilder<CompanyLocationStaffMemberAssignment>("query companyLocationStaffMemberAssignment")
{
    public CompanyLocationStaffMemberAssignmentQueryBuilder AddFieldCompanyLocation()
    {
        AddField("companyLocation");
        return this;
    }

    public CompanyLocationStaffMemberAssignmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CompanyLocationStaffMemberAssignmentQueryBuilder AddFieldStaffMember()
    {
        AddField("staffMember");
        return this;
    }
}