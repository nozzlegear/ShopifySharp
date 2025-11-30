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

public class FulfillmentOrdersQueryBuilder() : GraphQueryBuilder<FulfillmentOrderConnection>("query fulfillmentOrders")
{
    public FulfillmentOrdersQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public FulfillmentOrdersQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public FulfillmentOrdersQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public FulfillmentOrdersQueryBuilder AddArgumentIncludeClosed(bool? includeClosed)
    {
        AddArgument("includeClosed", includeClosed);
        return this;
    }

    public FulfillmentOrdersQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public FulfillmentOrdersQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public FulfillmentOrdersQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public FulfillmentOrdersQueryBuilder AddArgumentSortKey(FulfillmentOrderSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}