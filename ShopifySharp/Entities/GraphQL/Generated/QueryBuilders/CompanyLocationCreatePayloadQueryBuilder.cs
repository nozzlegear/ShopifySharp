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

public class CompanyLocationCreatePayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationCreatePayload>("query companyLocationCreatePayload")
{
    public CompanyLocationCreatePayloadQueryBuilder AddFieldCompanyLocation()
    {
        AddField("companyLocation");
        return this;
    }

    public CompanyLocationCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}