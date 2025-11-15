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

public class CompanyLocationCreateTaxRegistrationPayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationCreateTaxRegistrationPayload>("query companyLocationCreateTaxRegistrationPayload")
{
    public CompanyLocationCreateTaxRegistrationPayloadQueryBuilder AddFieldCompanyLocation()
    {
        AddField("companyLocation");
        return this;
    }

    public CompanyLocationCreateTaxRegistrationPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}