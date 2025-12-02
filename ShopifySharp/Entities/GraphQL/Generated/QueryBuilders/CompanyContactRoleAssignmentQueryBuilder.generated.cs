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

public class CompanyContactRoleAssignmentQueryBuilder() : GraphQueryBuilder<CompanyContactRoleAssignment>("companyContactRoleAssignment")
{
    public CompanyContactRoleAssignmentQueryBuilder AddFieldCompany(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddField<Company, CompanyQueryBuilder>("company", build);
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldCompanyContact(Func<CompanyContactQueryBuilder, CompanyContactQueryBuilder> build)
    {
        AddField<CompanyContact, CompanyContactQueryBuilder>("companyContact", build);
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldCompanyLocation(Func<CompanyLocationQueryBuilder, CompanyLocationQueryBuilder> build)
    {
        AddField<CompanyLocation, CompanyLocationQueryBuilder>("companyLocation", build);
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldRole(Func<CompanyContactRoleQueryBuilder, CompanyContactRoleQueryBuilder> build)
    {
        AddField<CompanyContactRole, CompanyContactRoleQueryBuilder>("role", build);
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}