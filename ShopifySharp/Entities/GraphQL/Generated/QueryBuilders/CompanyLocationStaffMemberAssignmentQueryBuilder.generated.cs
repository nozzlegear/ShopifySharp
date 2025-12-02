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

public class CompanyLocationStaffMemberAssignmentQueryBuilder() : GraphQueryBuilder<CompanyLocationStaffMemberAssignment>("companyLocationStaffMemberAssignment")
{
    public CompanyLocationStaffMemberAssignmentQueryBuilder AddFieldCompanyLocation(Func<CompanyLocationQueryBuilder, CompanyLocationQueryBuilder> build)
    {
        AddField<CompanyLocation, CompanyLocationQueryBuilder>("companyLocation", build);
        return this;
    }

    public CompanyLocationStaffMemberAssignmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CompanyLocationStaffMemberAssignmentQueryBuilder AddFieldStaffMember(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("staffMember", build);
        return this;
    }
}