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

public class CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder() : GraphQueryBuilder<CustomerEmailMarketingConsentUpdateUserError>("query customerEmailMarketingConsentUpdateUserError")
{
    public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}