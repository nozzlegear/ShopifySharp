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

public class CompanyContactAssignRolePayloadQueryBuilder() : GraphQueryBuilder<CompanyContactAssignRolePayload>("companyContactAssignRolePayload")
{
    public CompanyContactAssignRolePayloadQueryBuilder AddFieldCompanyContactRoleAssignment(Func<CompanyContactRoleAssignmentQueryBuilder, CompanyContactRoleAssignmentQueryBuilder> build)
    {
        AddField<CompanyContactRoleAssignment, CompanyContactRoleAssignmentQueryBuilder>("companyContactRoleAssignment", build);
        return this;
    }

    public CompanyContactAssignRolePayloadQueryBuilder AddFieldUserErrors(Func<BusinessCustomerUserErrorQueryBuilder, BusinessCustomerUserErrorQueryBuilder> build)
    {
        AddField<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}