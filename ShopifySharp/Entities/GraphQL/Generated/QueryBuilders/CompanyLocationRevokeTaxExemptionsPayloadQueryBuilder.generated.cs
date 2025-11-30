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

public class CompanyLocationRevokeTaxExemptionsPayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationRevokeTaxExemptionsPayload>("companyLocationRevokeTaxExemptionsPayload")
{
    public CompanyLocationRevokeTaxExemptionsPayloadQueryBuilder AddFieldCompanyLocation(Func<CompanyLocationQueryBuilder, CompanyLocationQueryBuilder> build)
    {
        AddField<CompanyLocation, CompanyLocationQueryBuilder>("companyLocation", build);
        return this;
    }

    public CompanyLocationRevokeTaxExemptionsPayloadQueryBuilder AddFieldUserErrors(Func<BusinessCustomerUserErrorQueryBuilder, BusinessCustomerUserErrorQueryBuilder> build)
    {
        AddField<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}