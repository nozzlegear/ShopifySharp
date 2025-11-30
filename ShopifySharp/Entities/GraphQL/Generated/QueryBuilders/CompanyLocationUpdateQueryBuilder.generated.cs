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

public class CompanyLocationUpdateQueryBuilder() : GraphQueryBuilder<CompanyLocationUpdatePayload>("companyLocationUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CompanyLocationUpdateQueryBuilder AddArgumentCompanyLocationId(string? companyLocationId)
    {
        AddArgument("companyLocationId", companyLocationId);
        return this;
    }

    public CompanyLocationUpdateQueryBuilder AddArgumentInput(CompanyLocationUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}