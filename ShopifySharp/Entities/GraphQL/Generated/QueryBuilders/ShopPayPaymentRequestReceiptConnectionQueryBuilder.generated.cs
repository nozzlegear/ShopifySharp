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

public class ShopPayPaymentRequestReceiptConnectionQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestReceiptConnection>("shopPayPaymentRequestReceiptConnection")
{
    public ShopPayPaymentRequestReceiptConnectionQueryBuilder AddFieldEdges(Func<ShopPayPaymentRequestReceiptEdgeQueryBuilder, ShopPayPaymentRequestReceiptEdgeQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestReceiptEdge, ShopPayPaymentRequestReceiptEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ShopPayPaymentRequestReceiptConnectionQueryBuilder AddFieldNodes(Func<ShopPayPaymentRequestReceiptQueryBuilder, ShopPayPaymentRequestReceiptQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestReceipt, ShopPayPaymentRequestReceiptQueryBuilder>("nodes", build);
        return this;
    }

    public ShopPayPaymentRequestReceiptConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}