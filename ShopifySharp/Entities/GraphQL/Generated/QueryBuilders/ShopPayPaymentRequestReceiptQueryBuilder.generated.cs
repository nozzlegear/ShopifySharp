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

public class ShopPayPaymentRequestReceiptQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestReceipt>("shopPayPaymentRequestReceipt")
{
    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldPaymentRequest(Func<ShopPayPaymentRequestQueryBuilder, ShopPayPaymentRequestQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequest, ShopPayPaymentRequestQueryBuilder>("paymentRequest", build);
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldProcessingStatus(Func<ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder, ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestReceiptProcessingStatus, ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder>("processingStatus", build);
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldSourceIdentifier()
    {
        AddField("sourceIdentifier");
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldToken()
    {
        AddField("token");
        return this;
    }
}