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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class OrderStagedChangeAddLineItemDiscountQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeAddLineItemDiscount, OrderStagedChangeAddLineItemDiscountQueryBuilder>
    {
        protected override OrderStagedChangeAddLineItemDiscountQueryBuilder Self => this;

        public OrderStagedChangeAddLineItemDiscountQueryBuilder() : this("orderStagedChangeAddLineItemDiscount")
        {
        }

        public OrderStagedChangeAddLineItemDiscountQueryBuilder(string name) : base(new Query<OrderStagedChangeAddLineItemDiscount>(name))
        {
        }

        public OrderStagedChangeAddLineItemDiscountQueryBuilder(IQuery<OrderStagedChangeAddLineItemDiscount> query) : base(query)
        {
        }

        public OrderStagedChangeAddLineItemDiscountQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public OrderStagedChangeAddLineItemDiscountQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OrderStagedChangeAddLineItemDiscountQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}