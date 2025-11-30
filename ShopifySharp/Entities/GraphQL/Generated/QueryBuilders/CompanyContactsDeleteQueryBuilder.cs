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

public class CompanyContactsDeleteQueryBuilder() : GraphQueryBuilder<CompanyContactsDeletePayload>("query companyContactsDelete")
{
    public CompanyContactsDeleteQueryBuilder AddArgumentCompanyContactIds(ICollection<string>? companyContactIds)
    {
        AddArgument("companyContactIds", companyContactIds);
        return this;
    }
}