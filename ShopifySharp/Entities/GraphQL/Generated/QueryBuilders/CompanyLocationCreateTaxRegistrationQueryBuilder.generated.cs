#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

[Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
public class CompanyLocationCreateTaxRegistrationQueryBuilder() : GraphQueryBuilder<CompanyLocationCreateTaxRegistrationPayload>("companyLocationCreateTaxRegistration"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

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