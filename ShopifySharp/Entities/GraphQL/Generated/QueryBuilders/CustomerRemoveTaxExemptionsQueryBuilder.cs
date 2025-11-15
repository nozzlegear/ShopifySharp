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

public class CustomerRemoveTaxExemptionsQueryBuilder() : GraphQueryBuilder<CustomerRemoveTaxExemptionsPayload>("query customerRemoveTaxExemptions")
{
    public CustomerRemoveTaxExemptionsQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }

    public CustomerRemoveTaxExemptionsQueryBuilder AddArgumentTaxExemptions(ICollection<TaxExemption>? taxExemptions)
    {
        AddArgument("taxExemptions", taxExemptions);
        return this;
    }
}