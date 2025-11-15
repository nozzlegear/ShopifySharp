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

public class CompanyLocationsDeletePayloadQueryBuilder() : GraphQueryBuilder<CompanyLocationsDeletePayload>("query companyLocationsDeletePayload")
{
    public CompanyLocationsDeletePayloadQueryBuilder AddFieldDeletedCompanyLocationIds()
    {
        AddField("deletedCompanyLocationIds");
        return this;
    }

    public CompanyLocationsDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}