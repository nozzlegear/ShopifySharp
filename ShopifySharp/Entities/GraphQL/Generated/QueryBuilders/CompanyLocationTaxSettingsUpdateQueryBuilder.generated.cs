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

public class CompanyLocationTaxSettingsUpdateQueryBuilder() : GraphQueryBuilder<CompanyLocationTaxSettingsUpdatePayload>("companyLocationTaxSettingsUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CompanyLocationTaxSettingsUpdateQueryBuilder AddArgumentCompanyLocationId(string? companyLocationId)
    {
        AddArgument("companyLocationId", companyLocationId);
        return this;
    }

    public CompanyLocationTaxSettingsUpdateQueryBuilder AddArgumentExemptionsToAssign(ICollection<TaxExemption>? exemptionsToAssign)
    {
        AddArgument("exemptionsToAssign", exemptionsToAssign);
        return this;
    }

    public CompanyLocationTaxSettingsUpdateQueryBuilder AddArgumentExemptionsToRemove(ICollection<TaxExemption>? exemptionsToRemove)
    {
        AddArgument("exemptionsToRemove", exemptionsToRemove);
        return this;
    }

    public CompanyLocationTaxSettingsUpdateQueryBuilder AddArgumentTaxExempt(bool? taxExempt)
    {
        AddArgument("taxExempt", taxExempt);
        return this;
    }

    public CompanyLocationTaxSettingsUpdateQueryBuilder AddArgumentTaxRegistrationId(string? taxRegistrationId)
    {
        AddArgument("taxRegistrationId", taxRegistrationId);
        return this;
    }
}