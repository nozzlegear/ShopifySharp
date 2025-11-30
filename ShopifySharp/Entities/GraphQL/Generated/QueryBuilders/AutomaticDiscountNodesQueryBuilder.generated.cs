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

public class AutomaticDiscountNodesQueryBuilder() : GraphQueryBuilder<DiscountAutomaticNodeConnection>("automaticDiscountNodes"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public AutomaticDiscountNodesQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public AutomaticDiscountNodesQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public AutomaticDiscountNodesQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public AutomaticDiscountNodesQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public AutomaticDiscountNodesQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public AutomaticDiscountNodesQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public AutomaticDiscountNodesQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }

    public AutomaticDiscountNodesQueryBuilder AddArgumentSortKey(AutomaticDiscountSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}