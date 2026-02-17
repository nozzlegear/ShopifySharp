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
    public sealed class OrderEditRemoveShippingLineArgumentsBuilder : ArgumentsBuilderBase<OrderEditRemoveShippingLinePayload, OrderEditRemoveShippingLineArgumentsBuilder>
    {
        protected override OrderEditRemoveShippingLineArgumentsBuilder Self => this;

        public OrderEditRemoveShippingLineArgumentsBuilder(IQuery<OrderEditRemoveShippingLinePayload> query) : base(query)
        {
        }

        public OrderEditRemoveShippingLineArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditRemoveShippingLineArgumentsBuilder ShippingLineId(string? shippingLineId)
        {
            base.InnerQuery.AddArgument("shippingLineId", shippingLineId);
            return this;
        }
    }
}