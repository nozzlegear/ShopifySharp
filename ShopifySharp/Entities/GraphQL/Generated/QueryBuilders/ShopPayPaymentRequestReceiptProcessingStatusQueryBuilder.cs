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

public class ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestReceiptProcessingStatus>("query shopPayPaymentRequestReceiptProcessingStatus")
{
    public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder AddFieldState()
    {
        AddField("state");
        return this;
    }
}