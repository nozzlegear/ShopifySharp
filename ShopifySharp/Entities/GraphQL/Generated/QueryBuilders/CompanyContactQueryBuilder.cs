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

public class CompanyContactQueryBuilder() : GraphQueryBuilder<CompanyContact>("query companyContact")
{
    public CompanyContactQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}