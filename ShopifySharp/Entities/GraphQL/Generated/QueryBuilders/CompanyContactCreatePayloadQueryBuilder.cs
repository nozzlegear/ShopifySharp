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

public class CompanyContactCreatePayloadQueryBuilder() : GraphQueryBuilder<CompanyContactCreatePayload>("query companyContactCreatePayload")
{
    public CompanyContactCreatePayloadQueryBuilder AddFieldCompanyContact()
    {
        AddField("companyContact");
        return this;
    }

    public CompanyContactCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}