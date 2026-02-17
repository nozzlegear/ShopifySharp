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
    public sealed class OrderCustomerRemoveArgumentsBuilder : ArgumentsBuilderBase<OrderCustomerRemovePayload, OrderCustomerRemoveArgumentsBuilder>
    {
        protected override OrderCustomerRemoveArgumentsBuilder Self => this;

        public OrderCustomerRemoveArgumentsBuilder(IQuery<OrderCustomerRemovePayload> query) : base(query)
        {
        }

        public OrderCustomerRemoveArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }
    }
}