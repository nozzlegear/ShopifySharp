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