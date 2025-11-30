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

public class CompanyLocationAssignStaffMembersPayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignStaffMembersPayload>("query companyLocationAssignStaffMembersPayload")
{
    public CompanyLocationAssignStaffMembersPayloadQueryBuilder AddFieldCompanyLocationStaffMemberAssignments()
    {
        AddField("companyLocationStaffMemberAssignments");
        return this;
    }

    public CompanyLocationAssignStaffMembersPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}