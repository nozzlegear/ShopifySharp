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

public class CompanyAddressDeletePayloadQueryBuilder() : GraphQueryBuilder<CompanyAddressDeletePayload>("query companyAddressDeletePayload")
{
    public CompanyAddressDeletePayloadQueryBuilder AddFieldDeletedAddressId()
    {
        AddField("deletedAddressId");
        return this;
    }

    public CompanyAddressDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}