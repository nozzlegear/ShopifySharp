#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class OrderPaymentStatusArgumentsBuilder : ArgumentsBuilderBase<OrderPaymentStatus, OrderPaymentStatusArgumentsBuilder>
    {
        protected override OrderPaymentStatusArgumentsBuilder Self => this;

        public OrderPaymentStatusArgumentsBuilder(IQuery<OrderPaymentStatus> query) : base(query)
        {
        }

        public OrderPaymentStatusArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }

        public OrderPaymentStatusArgumentsBuilder PaymentReferenceId(string? paymentReferenceId)
        {
            base.InnerQuery.AddArgument("paymentReferenceId", paymentReferenceId);
            return this;
        }
    }
}