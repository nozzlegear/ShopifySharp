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

public class CompanyContactDeletePayloadQueryBuilder() : GraphQueryBuilder<CompanyContactDeletePayload>("query companyContactDeletePayload")
{
    public CompanyContactDeletePayloadQueryBuilder AddFieldDeletedCompanyContactId()
    {
        AddField("deletedCompanyContactId");
        return this;
    }

    public CompanyContactDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}