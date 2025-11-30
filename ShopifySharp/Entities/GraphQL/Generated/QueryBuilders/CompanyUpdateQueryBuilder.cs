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

public class CompanyUpdateQueryBuilder() : GraphQueryBuilder<CompanyUpdatePayload>("query companyUpdate")
{
    public CompanyUpdateQueryBuilder AddArgumentCompanyId(string? companyId)
    {
        AddArgument("companyId", companyId);
        return this;
    }

    public CompanyUpdateQueryBuilder AddArgumentInput(CompanyInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}