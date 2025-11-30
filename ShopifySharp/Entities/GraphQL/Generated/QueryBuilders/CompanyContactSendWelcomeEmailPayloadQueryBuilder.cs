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

public class CompanyContactSendWelcomeEmailPayloadQueryBuilder() : GraphQueryBuilder<CompanyContactSendWelcomeEmailPayload>("query companyContactSendWelcomeEmailPayload")
{
    public CompanyContactSendWelcomeEmailPayloadQueryBuilder AddFieldCompanyContact()
    {
        AddField("companyContact");
        return this;
    }

    public CompanyContactSendWelcomeEmailPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}