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

public class CompanyContactRevokeRolesPayloadQueryBuilder() : GraphQueryBuilder<CompanyContactRevokeRolesPayload>("companyContactRevokeRolesPayload")
{
    public CompanyContactRevokeRolesPayloadQueryBuilder AddFieldRevokedRoleAssignmentIds()
    {
        AddField("revokedRoleAssignmentIds");
        return this;
    }

    public CompanyContactRevokeRolesPayloadQueryBuilder AddFieldUserErrors(Func<BusinessCustomerUserErrorQueryBuilder, BusinessCustomerUserErrorQueryBuilder> build)
    {
        AddField<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}