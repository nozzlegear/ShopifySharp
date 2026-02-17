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
    public sealed class OrderDeleteArgumentsBuilder : ArgumentsBuilderBase<OrderDeletePayload, OrderDeleteArgumentsBuilder>
    {
        protected override OrderDeleteArgumentsBuilder Self => this;

        public OrderDeleteArgumentsBuilder(IQuery<OrderDeletePayload> query) : base(query)
        {
        }

        public OrderDeleteArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }
    }
}