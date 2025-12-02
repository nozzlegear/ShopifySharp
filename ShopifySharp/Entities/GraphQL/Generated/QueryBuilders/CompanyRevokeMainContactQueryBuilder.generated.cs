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

public class CompanyRevokeMainContactQueryBuilder() : GraphQueryBuilder<CompanyRevokeMainContactPayload>("companyRevokeMainContact"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CompanyRevokeMainContactQueryBuilder AddArgumentCompanyId(string? companyId)
    {
        AddArgument("companyId", companyId);
        return this;
    }
}