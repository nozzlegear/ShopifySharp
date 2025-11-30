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

public class PaymentReminderSendPayloadQueryBuilder() : GraphQueryBuilder<PaymentReminderSendPayload>("paymentReminderSendPayload")
{
    public PaymentReminderSendPayloadQueryBuilder AddFieldSuccess()
    {
        AddField("success");
        return this;
    }

    public PaymentReminderSendPayloadQueryBuilder AddFieldUserErrors(Func<PaymentReminderSendUserErrorQueryBuilder, PaymentReminderSendUserErrorQueryBuilder> build)
    {
        AddField<PaymentReminderSendUserError, PaymentReminderSendUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}