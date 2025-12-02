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

[Obsolete("Use `events` instead.")]
public class DeletionEventsQueryBuilder() : GraphQueryBuilder<DeletionEventConnection>("deletionEvents"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public DeletionEventsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public DeletionEventsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public DeletionEventsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public DeletionEventsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public DeletionEventsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public DeletionEventsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public DeletionEventsQueryBuilder AddArgumentSortKey(DeletionEventSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }

    public DeletionEventsQueryBuilder AddArgumentSubjectTypes(ICollection<DeletionEventSubjectType>? subjectTypes)
    {
        AddArgument("subjectTypes", subjectTypes);
        return this;
    }
}