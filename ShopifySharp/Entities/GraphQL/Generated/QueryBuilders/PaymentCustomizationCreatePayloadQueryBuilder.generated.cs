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

public class PaymentCustomizationCreatePayloadQueryBuilder() : GraphQueryBuilder<PaymentCustomizationCreatePayload>("paymentCustomizationCreatePayload")
{
    public PaymentCustomizationCreatePayloadQueryBuilder AddFieldPaymentCustomization(Func<PaymentCustomizationQueryBuilder, PaymentCustomizationQueryBuilder> build)
    {
        AddField<PaymentCustomization, PaymentCustomizationQueryBuilder>("paymentCustomization", build);
        return this;
    }

    public PaymentCustomizationCreatePayloadQueryBuilder AddFieldUserErrors(Func<PaymentCustomizationErrorQueryBuilder, PaymentCustomizationErrorQueryBuilder> build)
    {
        AddField<PaymentCustomizationError, PaymentCustomizationErrorQueryBuilder>("userErrors", build);
        return this;
    }
}