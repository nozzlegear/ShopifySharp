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
public class CompanyLocationCreateTaxRegistrationQueryBuilder() : GraphQueryBuilder<CompanyLocationCreateTaxRegistrationPayload>("query companyLocationCreateTaxRegistration")
{
    public CompanyLocationCreateTaxRegistrationQueryBuilder AddArgumentLocationId(string? locationId)
    {
        AddArgument("locationId", locationId);
        return this;
    }

    public CompanyLocationCreateTaxRegistrationQueryBuilder AddArgumentTaxId(string? taxId)
    {
        AddArgument("taxId", taxId);
        return this;
    }
}