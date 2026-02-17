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
    public sealed class SubscriptionDiscountAllocationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountAllocation, SubscriptionDiscountAllocationQueryBuilder>
    {
        protected override SubscriptionDiscountAllocationQueryBuilder Self => this;

        public SubscriptionDiscountAllocationQueryBuilder() : this("subscriptionDiscountAllocation")
        {
        }

        public SubscriptionDiscountAllocationQueryBuilder(string name) : base(new Query<SubscriptionDiscountAllocation>(name))
        {
        }

        public SubscriptionDiscountAllocationQueryBuilder(IQuery<SubscriptionDiscountAllocation> query) : base(query)
        {
        }

        public SubscriptionDiscountAllocationQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionDiscountAllocationQueryBuilder Discount(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("discount");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}