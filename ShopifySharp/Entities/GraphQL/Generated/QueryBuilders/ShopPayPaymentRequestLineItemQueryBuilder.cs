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

public class ShopPayPaymentRequestLineItemQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestLineItem>("query shopPayPaymentRequestLineItem")
{
    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldFinalItemPrice()
    {
        AddField("finalItemPrice");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldFinalLinePrice()
    {
        AddField("finalLinePrice");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldItemDiscounts()
    {
        AddField("itemDiscounts");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldLabel()
    {
        AddField("label");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldLineDiscounts()
    {
        AddField("lineDiscounts");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldOriginalItemPrice()
    {
        AddField("originalItemPrice");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldOriginalLinePrice()
    {
        AddField("originalLinePrice");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }
}