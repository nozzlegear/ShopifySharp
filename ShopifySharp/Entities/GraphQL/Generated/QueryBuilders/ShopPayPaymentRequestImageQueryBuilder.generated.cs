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

public class ShopPayPaymentRequestImageQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestImage>("shopPayPaymentRequestImage")
{
    public ShopPayPaymentRequestImageQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public ShopPayPaymentRequestImageQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}