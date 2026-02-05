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
    public sealed class OrderCreateMandatePaymentArgumentsBuilder : ArgumentsBuilderBase<OrderCreateMandatePaymentPayload, OrderCreateMandatePaymentArgumentsBuilder>
    {
        protected override OrderCreateMandatePaymentArgumentsBuilder Self => this;

        public OrderCreateMandatePaymentArgumentsBuilder(IQuery<OrderCreateMandatePaymentPayload> query) : base(query)
        {
        }

        public OrderCreateMandatePaymentArgumentsBuilder Amount(MoneyInput? amount)
        {
            base.InnerQuery.AddArgument("amount", amount);
            return this;
        }

        public OrderCreateMandatePaymentArgumentsBuilder AutoCapture(bool? autoCapture)
        {
            base.InnerQuery.AddArgument("autoCapture", autoCapture);
            return this;
        }

        public OrderCreateMandatePaymentArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderCreateMandatePaymentArgumentsBuilder IdempotencyKey(string? idempotencyKey)
        {
            base.InnerQuery.AddArgument("idempotencyKey", idempotencyKey);
            return this;
        }

        public OrderCreateMandatePaymentArgumentsBuilder MandateId(string? mandateId)
        {
            base.InnerQuery.AddArgument("mandateId", mandateId);
            return this;
        }

        public OrderCreateMandatePaymentArgumentsBuilder PaymentScheduleId(string? paymentScheduleId)
        {
            base.InnerQuery.AddArgument("paymentScheduleId", paymentScheduleId);
            return this;
        }
    }
}