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

public class CompanyAddressDeleteQueryBuilder() : GraphQueryBuilder<CompanyAddressDeletePayload>("query companyAddressDelete")
{
    public CompanyAddressDeleteQueryBuilder AddArgumentAddressId(string? addressId)
    {
        AddArgument("addressId", addressId);
        return this;
    }
}