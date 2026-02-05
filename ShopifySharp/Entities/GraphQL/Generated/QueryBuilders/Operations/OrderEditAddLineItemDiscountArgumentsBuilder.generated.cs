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
    public sealed class OrderEditAddLineItemDiscountArgumentsBuilder : ArgumentsBuilderBase<OrderEditAddLineItemDiscountPayload, OrderEditAddLineItemDiscountArgumentsBuilder>
    {
        protected override OrderEditAddLineItemDiscountArgumentsBuilder Self => this;

        public OrderEditAddLineItemDiscountArgumentsBuilder(IQuery<OrderEditAddLineItemDiscountPayload> query) : base(query)
        {
        }

        public OrderEditAddLineItemDiscountArgumentsBuilder Discount(OrderEditAppliedDiscountInput? discount)
        {
            base.InnerQuery.AddArgument("discount", discount);
            return this;
        }

        public OrderEditAddLineItemDiscountArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditAddLineItemDiscountArgumentsBuilder LineItemId(string? lineItemId)
        {
            base.InnerQuery.AddArgument("lineItemId", lineItemId);
            return this;
        }
    }
}