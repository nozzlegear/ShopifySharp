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

public class CompanyContactSendWelcomeEmailPayloadQueryBuilder() : GraphQueryBuilder<CompanyContactSendWelcomeEmailPayload>("companyContactSendWelcomeEmailPayload")
{
    public CompanyContactSendWelcomeEmailPayloadQueryBuilder AddFieldCompanyContact(Func<CompanyContactQueryBuilder, CompanyContactQueryBuilder> build)
    {
        AddField<CompanyContact, CompanyContactQueryBuilder>("companyContact", build);
        return this;
    }

    public CompanyContactSendWelcomeEmailPayloadQueryBuilder AddFieldUserErrors(Func<BusinessCustomerUserErrorQueryBuilder, BusinessCustomerUserErrorQueryBuilder> build)
    {
        AddField<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}