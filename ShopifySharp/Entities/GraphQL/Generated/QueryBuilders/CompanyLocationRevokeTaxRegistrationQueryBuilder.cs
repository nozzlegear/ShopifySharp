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

[Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
public class CompanyLocationRevokeTaxRegistrationQueryBuilder() : GraphQueryBuilder<CompanyLocationRevokeTaxRegistrationPayload>("query companyLocationRevokeTaxRegistration")
{
    public CompanyLocationRevokeTaxRegistrationQueryBuilder AddArgumentCompanyLocationId(string? companyLocationId)
    {
        AddArgument("companyLocationId", companyLocationId);
        return this;
    }
}