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

public class CustomerSmsMarketingConsentStateQueryBuilder() : GraphQueryBuilder<CustomerSmsMarketingConsentState>("query customerSmsMarketingConsentState")
{
    public CustomerSmsMarketingConsentStateQueryBuilder AddFieldConsentCollectedFrom()
    {
        AddField("consentCollectedFrom");
        return this;
    }

    public CustomerSmsMarketingConsentStateQueryBuilder AddFieldConsentUpdatedAt()
    {
        AddField("consentUpdatedAt");
        return this;
    }

    public CustomerSmsMarketingConsentStateQueryBuilder AddFieldMarketingOptInLevel()
    {
        AddField("marketingOptInLevel");
        return this;
    }

    public CustomerSmsMarketingConsentStateQueryBuilder AddFieldMarketingState()
    {
        AddField("marketingState");
        return this;
    }

    public CustomerSmsMarketingConsentStateQueryBuilder AddFieldSourceLocation()
    {
        AddField("sourceLocation");
        return this;
    }
}