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
    public sealed class OrderEditUpdateDiscountArgumentsBuilder : ArgumentsBuilderBase<OrderEditUpdateDiscountPayload, OrderEditUpdateDiscountArgumentsBuilder>
    {
        protected override OrderEditUpdateDiscountArgumentsBuilder Self => this;

        public OrderEditUpdateDiscountArgumentsBuilder(IQuery<OrderEditUpdateDiscountPayload> query) : base(query)
        {
        }

        public OrderEditUpdateDiscountArgumentsBuilder Discount(OrderEditAppliedDiscountInput? discount)
        {
            base.InnerQuery.AddArgument("discount", discount);
            return this;
        }

        public OrderEditUpdateDiscountArgumentsBuilder DiscountApplicationId(string? discountApplicationId)
        {
            base.InnerQuery.AddArgument("discountApplicationId", discountApplicationId);
            return this;
        }

        public OrderEditUpdateDiscountArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}