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

public class CompaniesDeleteQueryBuilder() : GraphQueryBuilder<CompaniesDeletePayload>("query companiesDelete")
{
    public CompaniesDeleteQueryBuilder AddArgumentCompanyIds(ICollection<string>? companyIds)
    {
        AddArgument("companyIds", companyIds);
        return this;
    }
}