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
    public sealed class OrderCustomerSetArgumentsBuilder : ArgumentsBuilderBase<OrderCustomerSetPayload, OrderCustomerSetArgumentsBuilder>
    {
        protected override OrderCustomerSetArgumentsBuilder Self => this;

        public OrderCustomerSetArgumentsBuilder(IQuery<OrderCustomerSetPayload> query) : base(query)
        {
        }

        public OrderCustomerSetArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public OrderCustomerSetArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }
    }
}