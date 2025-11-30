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

public class CodeDiscountNodeByCodeQueryBuilder() : GraphQueryBuilder<DiscountCodeNode>("codeDiscountNodeByCode"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public CodeDiscountNodeByCodeQueryBuilder AddArgumentCode(string? code)
    {
        AddArgument("code", code);
        return this;
    }
}