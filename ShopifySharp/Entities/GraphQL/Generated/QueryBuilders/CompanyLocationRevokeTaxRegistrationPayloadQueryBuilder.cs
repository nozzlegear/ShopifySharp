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

public class CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationRevokeTaxRegistrationPayload>("query companyLocationRevokeTaxRegistrationPayload")
{
    public CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder AddFieldCompanyLocation()
    {
        AddField("companyLocation");
        return this;
    }

    public CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}