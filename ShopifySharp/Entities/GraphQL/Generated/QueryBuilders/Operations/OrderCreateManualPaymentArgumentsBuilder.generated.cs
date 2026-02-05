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
    public sealed class OrderCreateManualPaymentArgumentsBuilder : ArgumentsBuilderBase<OrderCreateManualPaymentPayload, OrderCreateManualPaymentArgumentsBuilder>
    {
        protected override OrderCreateManualPaymentArgumentsBuilder Self => this;

        public OrderCreateManualPaymentArgumentsBuilder(IQuery<OrderCreateManualPaymentPayload> query) : base(query)
        {
        }

        public OrderCreateManualPaymentArgumentsBuilder Amount(MoneyInput? amount)
        {
            base.InnerQuery.AddArgument("amount", amount);
            return this;
        }

        public OrderCreateManualPaymentArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderCreateManualPaymentArgumentsBuilder PaymentMethodName(string? paymentMethodName)
        {
            base.InnerQuery.AddArgument("paymentMethodName", paymentMethodName);
            return this;
        }

        public OrderCreateManualPaymentArgumentsBuilder ProcessedAt(DateTimeOffset? processedAt)
        {
            base.InnerQuery.AddArgument("processedAt", processedAt);
            return this;
        }
    }
}