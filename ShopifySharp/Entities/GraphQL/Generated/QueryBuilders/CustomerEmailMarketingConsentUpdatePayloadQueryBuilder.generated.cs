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

public class CustomerEmailMarketingConsentUpdatePayloadQueryBuilder() : GraphQueryBuilder<CustomerEmailMarketingConsentUpdatePayload>("customerEmailMarketingConsentUpdatePayload")
{
    public CustomerEmailMarketingConsentUpdatePayloadQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public CustomerEmailMarketingConsentUpdatePayloadQueryBuilder AddFieldUserErrors(Func<CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder, CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder> build)
    {
        AddField<CustomerEmailMarketingConsentUpdateUserError, CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}