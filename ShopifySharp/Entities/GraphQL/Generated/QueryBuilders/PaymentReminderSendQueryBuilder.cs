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

public class PaymentReminderSendQueryBuilder() : GraphQueryBuilder<PaymentReminderSendPayload>("query paymentReminderSend")
{
    public PaymentReminderSendQueryBuilder AddArgumentPaymentScheduleId(string? paymentScheduleId)
    {
        AddArgument("paymentScheduleId", paymentScheduleId);
        return this;
    }
}