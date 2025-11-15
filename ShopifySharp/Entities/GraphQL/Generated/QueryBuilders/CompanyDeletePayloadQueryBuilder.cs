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

public class CompanyDeletePayloadQueryBuilder() : GraphQueryBuilder<CompanyDeletePayload>("query companyDeletePayload")
{
    public CompanyDeletePayloadQueryBuilder AddFieldDeletedCompanyId()
    {
        AddField("deletedCompanyId");
        return this;
    }

    public CompanyDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}