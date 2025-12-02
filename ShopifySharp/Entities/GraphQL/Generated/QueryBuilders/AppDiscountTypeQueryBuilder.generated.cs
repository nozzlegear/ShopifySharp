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

public class AppDiscountTypeQueryBuilder() : GraphQueryBuilder<AppDiscountType>("appDiscountType"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public AppDiscountTypeQueryBuilder AddArgumentFunctionId(string? functionId)
    {
        AddArgument("functionId", functionId);
        return this;
    }
}