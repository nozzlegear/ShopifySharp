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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootOrderPaymentStatusArgumentsBuilder : ArgumentsBuilderBase<OrderPaymentStatus?, QueryRootOrderPaymentStatusArgumentsBuilder>
    {
        protected override QueryRootOrderPaymentStatusArgumentsBuilder Self => this;

        public QueryRootOrderPaymentStatusArgumentsBuilder(IQuery<OrderPaymentStatus?> query) : base(query)
        {
        }

        public QueryRootOrderPaymentStatusArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }

        public QueryRootOrderPaymentStatusArgumentsBuilder PaymentReferenceId(string? paymentReferenceId)
        {
            base.InnerQuery.AddArgument("paymentReferenceId", paymentReferenceId);
            return this;
        }
    }
}