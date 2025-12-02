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

public class ShopPayPaymentRequestReceiptEdgeQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestReceiptEdge>("shopPayPaymentRequestReceiptEdge")
{
    public ShopPayPaymentRequestReceiptEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ShopPayPaymentRequestReceiptEdgeQueryBuilder AddFieldNode(Func<ShopPayPaymentRequestReceiptQueryBuilder, ShopPayPaymentRequestReceiptQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestReceipt, ShopPayPaymentRequestReceiptQueryBuilder>("node", build);
        return this;
    }
}