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