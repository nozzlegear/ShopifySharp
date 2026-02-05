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
    public sealed class OrderEditAddShippingLineArgumentsBuilder : ArgumentsBuilderBase<OrderEditAddShippingLinePayload, OrderEditAddShippingLineArgumentsBuilder>
    {
        protected override OrderEditAddShippingLineArgumentsBuilder Self => this;

        public OrderEditAddShippingLineArgumentsBuilder(IQuery<OrderEditAddShippingLinePayload> query) : base(query)
        {
        }

        public OrderEditAddShippingLineArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditAddShippingLineArgumentsBuilder ShippingLine(OrderEditAddShippingLineInput? shippingLine)
        {
            base.InnerQuery.AddArgument("shippingLine", shippingLine);
            return this;
        }
    }
}