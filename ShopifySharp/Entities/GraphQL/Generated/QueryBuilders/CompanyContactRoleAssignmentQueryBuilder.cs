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

public class CompanyContactRoleAssignmentQueryBuilder() : GraphQueryBuilder<CompanyContactRoleAssignment>("query companyContactRoleAssignment")
{
    public CompanyContactRoleAssignmentQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldCompanyContact()
    {
        AddField("companyContact");
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldCompanyLocation()
    {
        AddField("companyLocation");
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

    public CompanyContactRoleAssignmentQueryBuilder AddFieldRole()
    {
        AddField("role");
        return this;
    }

    public CompanyContactRoleAssignmentQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}