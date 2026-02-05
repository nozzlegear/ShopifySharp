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
    public sealed class OrderEditRemoveLineItemDiscountArgumentsBuilder : ArgumentsBuilderBase<OrderEditRemoveLineItemDiscountPayload, OrderEditRemoveLineItemDiscountArgumentsBuilder>
    {
        protected override OrderEditRemoveLineItemDiscountArgumentsBuilder Self => this;

        public OrderEditRemoveLineItemDiscountArgumentsBuilder(IQuery<OrderEditRemoveLineItemDiscountPayload> query) : base(query)
        {
        }

        public OrderEditRemoveLineItemDiscountArgumentsBuilder DiscountApplicationId(string? discountApplicationId)
        {
            base.InnerQuery.AddArgument("discountApplicationId", discountApplicationId);
            return this;
        }

        public OrderEditRemoveLineItemDiscountArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}