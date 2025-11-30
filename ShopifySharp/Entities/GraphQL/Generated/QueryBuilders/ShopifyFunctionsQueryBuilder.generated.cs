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

public class ShopifyFunctionsQueryBuilder() : GraphQueryBuilder<ShopifyFunctionConnection>("shopifyFunctions"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public ShopifyFunctionsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public ShopifyFunctionsQueryBuilder AddArgumentApiType(string? apiType)
    {
        AddArgument("apiType", apiType);
        return this;
    }

    public ShopifyFunctionsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public ShopifyFunctionsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public ShopifyFunctionsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public ShopifyFunctionsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public ShopifyFunctionsQueryBuilder AddArgumentUseCreationUi(bool? useCreationUi)
    {
        AddArgument("useCreationUi", useCreationUi);
        return this;
    }
}