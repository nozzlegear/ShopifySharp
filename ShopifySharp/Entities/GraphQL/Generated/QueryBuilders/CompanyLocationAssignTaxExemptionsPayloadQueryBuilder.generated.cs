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

public class CompanyLocationAssignTaxExemptionsPayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignTaxExemptionsPayload>("companyLocationAssignTaxExemptionsPayload")
{
    public CompanyLocationAssignTaxExemptionsPayloadQueryBuilder AddFieldCompanyLocation(Func<CompanyLocationQueryBuilder, CompanyLocationQueryBuilder> build)
    {
        AddField<CompanyLocation, CompanyLocationQueryBuilder>("companyLocation", build);
        return this;
    }

    public CompanyLocationAssignTaxExemptionsPayloadQueryBuilder AddFieldUserErrors(Func<BusinessCustomerUserErrorQueryBuilder, BusinessCustomerUserErrorQueryBuilder> build)
    {
        AddField<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}