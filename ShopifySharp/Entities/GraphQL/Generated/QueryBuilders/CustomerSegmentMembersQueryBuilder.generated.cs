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

public class CustomerSegmentMembersQueryBuilder() : GraphQueryBuilder<CustomerSegmentMemberConnection>("customerSegmentMembers"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public CustomerSegmentMembersQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentQueryId(string? queryId)
    {
        AddArgument("queryId", queryId);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentSegmentId(string? segmentId)
    {
        AddArgument("segmentId", segmentId);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentSortKey(string? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }

    public CustomerSegmentMembersQueryBuilder AddArgumentTimezone(string? timezone)
    {
        AddArgument("timezone", timezone);
        return this;
    }
}