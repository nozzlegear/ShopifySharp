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

public class CustomerSmsMarketingConsentErrorQueryBuilder() : GraphQueryBuilder<CustomerSmsMarketingConsentError>("query customerSmsMarketingConsentError")
{
    public CustomerSmsMarketingConsentErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerSmsMarketingConsentErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerSmsMarketingConsentErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}