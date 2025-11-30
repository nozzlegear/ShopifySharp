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

public class CompanyCreatePayloadQueryBuilder() : GraphQueryBuilder<CompanyCreatePayload>("companyCreatePayload")
{
    public CompanyCreatePayloadQueryBuilder AddFieldCompany(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddField<Company, CompanyQueryBuilder>("company", build);
        return this;
    }

    public CompanyCreatePayloadQueryBuilder AddFieldUserErrors(Func<BusinessCustomerUserErrorQueryBuilder, BusinessCustomerUserErrorQueryBuilder> build)
    {
        AddField<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}