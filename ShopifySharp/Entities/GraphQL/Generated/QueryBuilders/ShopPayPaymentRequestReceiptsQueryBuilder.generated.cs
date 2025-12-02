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

public class ShopPayPaymentRequestReceiptsQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestReceiptConnection>("shopPayPaymentRequestReceipts"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public ShopPayPaymentRequestReceiptsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public ShopPayPaymentRequestReceiptsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public ShopPayPaymentRequestReceiptsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public ShopPayPaymentRequestReceiptsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public ShopPayPaymentRequestReceiptsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public ShopPayPaymentRequestReceiptsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public ShopPayPaymentRequestReceiptsQueryBuilder AddArgumentSortKey(ShopPayPaymentRequestReceiptsSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}