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

public class PaymentCustomizationDeletePayloadQueryBuilder() : GraphQueryBuilder<PaymentCustomizationDeletePayload>("paymentCustomizationDeletePayload")
{
    public PaymentCustomizationDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public PaymentCustomizationDeletePayloadQueryBuilder AddFieldUserErrors(Func<PaymentCustomizationErrorQueryBuilder, PaymentCustomizationErrorQueryBuilder> build)
    {
        AddField<PaymentCustomizationError, PaymentCustomizationErrorQueryBuilder>("userErrors", build);
        return this;
    }
}