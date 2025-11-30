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

public class CustomerSmsMarketingConsentStateQueryBuilder() : GraphQueryBuilder<CustomerSmsMarketingConsentState>("customerSmsMarketingConsentState")
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

    public CustomerSmsMarketingConsentStateQueryBuilder AddFieldSourceLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("sourceLocation", build);
        return this;
    }
}