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

public class CustomerSmsMarketingConsentUpdatePayloadQueryBuilder() : GraphQueryBuilder<CustomerSmsMarketingConsentUpdatePayload>("customerSmsMarketingConsentUpdatePayload")
{
    public CustomerSmsMarketingConsentUpdatePayloadQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public CustomerSmsMarketingConsentUpdatePayloadQueryBuilder AddFieldUserErrors(Func<CustomerSmsMarketingConsentErrorQueryBuilder, CustomerSmsMarketingConsentErrorQueryBuilder> build)
    {
        AddField<CustomerSmsMarketingConsentError, CustomerSmsMarketingConsentErrorQueryBuilder>("userErrors", build);
        return this;
    }
}