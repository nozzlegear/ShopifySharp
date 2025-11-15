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

public class PaymentReminderSendUserErrorQueryBuilder() : GraphQueryBuilder<PaymentReminderSendUserError>("query paymentReminderSendUserError")
{
    public PaymentReminderSendUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PaymentReminderSendUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PaymentReminderSendUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}