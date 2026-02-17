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
    public sealed class OrderEditRemoveDiscountArgumentsBuilder : ArgumentsBuilderBase<OrderEditRemoveDiscountPayload, OrderEditRemoveDiscountArgumentsBuilder>
    {
        protected override OrderEditRemoveDiscountArgumentsBuilder Self => this;

        public OrderEditRemoveDiscountArgumentsBuilder(IQuery<OrderEditRemoveDiscountPayload> query) : base(query)
        {
        }

        public OrderEditRemoveDiscountArgumentsBuilder DiscountApplicationId(string? discountApplicationId)
        {
            base.InnerQuery.AddArgument("discountApplicationId", discountApplicationId);
            return this;
        }

        public OrderEditRemoveDiscountArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}