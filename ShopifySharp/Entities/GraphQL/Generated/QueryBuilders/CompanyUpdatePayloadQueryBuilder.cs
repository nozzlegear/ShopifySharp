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

public class CompanyUpdatePayloadQueryBuilder() : GraphQueryBuilder<CompanyUpdatePayload>("query companyUpdatePayload")
{
    public CompanyUpdatePayloadQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public CompanyUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}