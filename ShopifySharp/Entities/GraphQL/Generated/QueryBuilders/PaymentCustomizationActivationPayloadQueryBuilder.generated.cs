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

public class PaymentCustomizationActivationPayloadQueryBuilder() : GraphQueryBuilder<PaymentCustomizationActivationPayload>("paymentCustomizationActivationPayload")
{
    public PaymentCustomizationActivationPayloadQueryBuilder AddFieldIds()
    {
        AddField("ids");
        return this;
    }

    public PaymentCustomizationActivationPayloadQueryBuilder AddFieldUserErrors(Func<PaymentCustomizationErrorQueryBuilder, PaymentCustomizationErrorQueryBuilder> build)
    {
        AddField<PaymentCustomizationError, PaymentCustomizationErrorQueryBuilder>("userErrors", build);
        return this;
    }
}