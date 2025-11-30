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

public class MetaobjectsQueryBuilder() : GraphQueryBuilder<MetaobjectConnection>("metaobjects"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public MetaobjectsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public MetaobjectsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public MetaobjectsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public MetaobjectsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public MetaobjectsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public MetaobjectsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public MetaobjectsQueryBuilder AddArgumentSortKey(string? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }

    public MetaobjectsQueryBuilder AddArgumentType(string? type)
    {
        AddArgument("type", type);
        return this;
    }
}