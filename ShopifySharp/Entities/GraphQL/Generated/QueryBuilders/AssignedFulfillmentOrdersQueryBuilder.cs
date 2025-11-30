#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class AssignedFulfillmentOrdersQueryBuilder() : GraphQueryBuilder<FulfillmentOrderConnection>("query assignedFulfillmentOrders")
{
    public AssignedFulfillmentOrdersQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public AssignedFulfillmentOrdersQueryBuilder AddArgumentAssignmentStatus(FulfillmentOrderAssignmentStatus? assignmentStatus)
    {
        AddArgument("assignmentStatus", assignmentStatus);
        return this;
    }

    public AssignedFulfillmentOrdersQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public AssignedFulfillmentOrdersQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public AssignedFulfillmentOrdersQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public AssignedFulfillmentOrdersQueryBuilder AddArgumentLocationIds(ICollection<string>? locationIds)
    {
        AddArgument("locationIds", locationIds);
        return this;
    }

    public AssignedFulfillmentOrdersQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public AssignedFulfillmentOrdersQueryBuilder AddArgumentSortKey(FulfillmentOrderSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}