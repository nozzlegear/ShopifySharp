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

public class CompanyLocationTaxSettingsUpdatePayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationTaxSettingsUpdatePayload>("query companyLocationTaxSettingsUpdatePayload")
{
    public CompanyLocationTaxSettingsUpdatePayloadQueryBuilder AddFieldCompanyLocation()
    {
        AddField("companyLocation");
        return this;
    }

    public CompanyLocationTaxSettingsUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}