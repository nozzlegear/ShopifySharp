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

public class CompanyCreatePayloadQueryBuilder() : GraphQueryBuilder<CompanyCreatePayload>("query companyCreatePayload")
{
    public CompanyCreatePayloadQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public CompanyCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}