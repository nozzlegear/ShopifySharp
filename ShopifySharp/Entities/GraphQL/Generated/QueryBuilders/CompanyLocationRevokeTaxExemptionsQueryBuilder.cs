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
public class CompanyLocationRevokeTaxExemptionsQueryBuilder() : GraphQueryBuilder<CompanyLocationRevokeTaxExemptionsPayload>("query companyLocationRevokeTaxExemptions")
{
    public CompanyLocationRevokeTaxExemptionsQueryBuilder AddArgumentCompanyLocationId(string? companyLocationId)
    {
        AddArgument("companyLocationId", companyLocationId);
        return this;
    }

    public CompanyLocationRevokeTaxExemptionsQueryBuilder AddArgumentTaxExemptions(ICollection<TaxExemption>? taxExemptions)
    {
        AddArgument("taxExemptions", taxExemptions);
        return this;
    }
}