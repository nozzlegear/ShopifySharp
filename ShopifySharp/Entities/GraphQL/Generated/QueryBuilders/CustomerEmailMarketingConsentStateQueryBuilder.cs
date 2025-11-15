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

public class CustomerEmailMarketingConsentStateQueryBuilder() : GraphQueryBuilder<CustomerEmailMarketingConsentState>("query customerEmailMarketingConsentState")
{
    public CustomerEmailMarketingConsentStateQueryBuilder AddFieldConsentUpdatedAt()
    {
        AddField("consentUpdatedAt");
        return this;
    }

    public CustomerEmailMarketingConsentStateQueryBuilder AddFieldMarketingOptInLevel()
    {
        AddField("marketingOptInLevel");
        return this;
    }

    public CustomerEmailMarketingConsentStateQueryBuilder AddFieldMarketingState()
    {
        AddField("marketingState");
        return this;
    }

    public CustomerEmailMarketingConsentStateQueryBuilder AddFieldSourceLocation()
    {
        AddField("sourceLocation");
        return this;
    }
}