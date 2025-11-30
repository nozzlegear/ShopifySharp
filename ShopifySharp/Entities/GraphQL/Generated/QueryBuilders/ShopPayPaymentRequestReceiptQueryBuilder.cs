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

public class ShopPayPaymentRequestReceiptQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestReceipt>("query shopPayPaymentRequestReceipt")
{
    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldPaymentRequest()
    {
        AddField("paymentRequest");
        return this;
    }

    public ShopPayPaymentRequestReceiptQueryBuilder AddFieldProcessingStatus()
    {
        AddField("processingStatus");
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