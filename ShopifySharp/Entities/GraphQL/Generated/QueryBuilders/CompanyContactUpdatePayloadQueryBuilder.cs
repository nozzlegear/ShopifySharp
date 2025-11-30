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

public class CompanyContactUpdatePayloadQueryBuilder() : GraphQueryBuilder<CompanyContactUpdatePayload>("query companyContactUpdatePayload")
{
    public CompanyContactUpdatePayloadQueryBuilder AddFieldCompanyContact()
    {
        AddField("companyContact");
        return this;
    }

    public CompanyContactUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}