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

public class CompanyContactRemoveFromCompanyQueryBuilder() : GraphQueryBuilder<CompanyContactRemoveFromCompanyPayload>("query companyContactRemoveFromCompany")
{
    public CompanyContactRemoveFromCompanyQueryBuilder AddArgumentCompanyContactId(string? companyContactId)
    {
        AddArgument("companyContactId", companyContactId);
        return this;
    }
}