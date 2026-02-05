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
    public sealed class OrderCreateArgumentsBuilder : ArgumentsBuilderBase<OrderCreatePayload, OrderCreateArgumentsBuilder>
    {
        protected override OrderCreateArgumentsBuilder Self => this;

        public OrderCreateArgumentsBuilder(IQuery<OrderCreatePayload> query) : base(query)
        {
        }

        public OrderCreateArgumentsBuilder Options(OrderCreateOptionsInput? options)
        {
            base.InnerQuery.AddArgument("options", options);
            return this;
        }

        public OrderCreateArgumentsBuilder Order(OrderCreateOrderInput? order)
        {
            base.InnerQuery.AddArgument("order", order);
            return this;
        }
    }
}