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