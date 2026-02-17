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
    public sealed class OrderCancelArgumentsBuilder : ArgumentsBuilderBase<OrderCancelPayload, OrderCancelArgumentsBuilder>
    {
        protected override OrderCancelArgumentsBuilder Self => this;

        public OrderCancelArgumentsBuilder(IQuery<OrderCancelPayload> query) : base(query)
        {
        }

        public OrderCancelArgumentsBuilder NotifyCustomer(bool? notifyCustomer)
        {
            base.InnerQuery.AddArgument("notifyCustomer", notifyCustomer);
            return this;
        }

        public OrderCancelArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }

        public OrderCancelArgumentsBuilder Reason(OrderCancelReason? reason)
        {
            base.InnerQuery.AddArgument("reason", reason);
            return this;
        }

        public OrderCancelArgumentsBuilder RefundMethod(OrderCancelRefundMethodInput? refundMethod)
        {
            base.InnerQuery.AddArgument("refundMethod", refundMethod);
            return this;
        }

        public OrderCancelArgumentsBuilder Restock(bool? restock)
        {
            base.InnerQuery.AddArgument("restock", restock);
            return this;
        }

        public OrderCancelArgumentsBuilder StaffNote(string? staffNote)
        {
            base.InnerQuery.AddArgument("staffNote", staffNote);
            return this;
        }
    }
}