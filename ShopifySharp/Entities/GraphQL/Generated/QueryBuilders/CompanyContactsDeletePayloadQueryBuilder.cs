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

public class CompanyContactsDeletePayloadQueryBuilder() : GraphQueryBuilder<CompanyContactsDeletePayload>("query companyContactsDeletePayload")
{
    public CompanyContactsDeletePayloadQueryBuilder AddFieldDeletedCompanyContactIds()
    {
        AddField("deletedCompanyContactIds");
        return this;
    }

    public CompanyContactsDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}