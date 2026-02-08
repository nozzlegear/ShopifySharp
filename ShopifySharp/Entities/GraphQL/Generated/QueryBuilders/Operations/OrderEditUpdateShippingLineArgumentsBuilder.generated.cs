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
    public sealed class OrderEditUpdateShippingLineArgumentsBuilder : ArgumentsBuilderBase<OrderEditUpdateShippingLinePayload, OrderEditUpdateShippingLineArgumentsBuilder>
    {
        protected override OrderEditUpdateShippingLineArgumentsBuilder Self => this;

        public OrderEditUpdateShippingLineArgumentsBuilder(IQuery<OrderEditUpdateShippingLinePayload> query) : base(query)
        {
        }

        public OrderEditUpdateShippingLineArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditUpdateShippingLineArgumentsBuilder ShippingLine(OrderEditUpdateShippingLineInput? shippingLine)
        {
            base.InnerQuery.AddArgument("shippingLine", shippingLine);
            return this;
        }

        public OrderEditUpdateShippingLineArgumentsBuilder ShippingLineId(string? shippingLineId)
        {
            base.InnerQuery.AddArgument("shippingLineId", shippingLineId);
            return this;
        }
    }
}