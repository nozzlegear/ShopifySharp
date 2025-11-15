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

public class CompanyLocationAssignAddressQueryBuilder() : GraphQueryBuilder<CompanyLocationAssignAddressPayload>("query companyLocationAssignAddress")
{
    public CompanyLocationAssignAddressQueryBuilder AddArgumentAddress(CompanyAddressInput? address)
    {
        AddArgument("address", address);
        return this;
    }

    public CompanyLocationAssignAddressQueryBuilder AddArgumentAddressTypes(ICollection<CompanyAddressType>? addressTypes)
    {
        AddArgument("addressTypes", addressTypes);
        return this;
    }

    public CompanyLocationAssignAddressQueryBuilder AddArgumentLocationId(string? locationId)
    {
        AddArgument("locationId", locationId);
        return this;
    }
}