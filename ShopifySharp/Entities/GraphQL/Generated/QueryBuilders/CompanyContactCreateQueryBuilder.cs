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

public class CompanyContactCreateQueryBuilder() : GraphQueryBuilder<CompanyContactCreatePayload>("query companyContactCreate")
{
    public CompanyContactCreateQueryBuilder AddArgumentCompanyId(string? companyId)
    {
        AddArgument("companyId", companyId);
        return this;
    }

    public CompanyContactCreateQueryBuilder AddArgumentInput(CompanyContactInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}