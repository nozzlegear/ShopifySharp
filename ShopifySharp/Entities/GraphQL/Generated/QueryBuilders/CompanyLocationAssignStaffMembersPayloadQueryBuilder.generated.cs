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

public class CompanyLocationAssignStaffMembersPayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignStaffMembersPayload>("companyLocationAssignStaffMembersPayload")
{
    public CompanyLocationAssignStaffMembersPayloadQueryBuilder AddFieldCompanyLocationStaffMemberAssignments(Func<CompanyLocationStaffMemberAssignmentQueryBuilder, CompanyLocationStaffMemberAssignmentQueryBuilder> build)
    {
        AddField<CompanyLocationStaffMemberAssignment, CompanyLocationStaffMemberAssignmentQueryBuilder>("companyLocationStaffMemberAssignments", build);
        return this;
    }

    public CompanyLocationAssignStaffMembersPayloadQueryBuilder AddFieldUserErrors(Func<BusinessCustomerUserErrorQueryBuilder, BusinessCustomerUserErrorQueryBuilder> build)
    {
        AddField<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}