#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PaymentReminderSendArgumentsBuilder : ArgumentsBuilderBase<PaymentReminderSendPayload, PaymentReminderSendArgumentsBuilder>
    {
        protected override PaymentReminderSendArgumentsBuilder Self => this;

        public PaymentReminderSendArgumentsBuilder(IQuery<PaymentReminderSendPayload> query) : base(query)
        {
        }

        public PaymentReminderSendArgumentsBuilder PaymentScheduleId(string? paymentScheduleId)
        {
            base.InnerQuery.AddArgument("paymentScheduleId", paymentScheduleId);
            return this;
        }
    }
}