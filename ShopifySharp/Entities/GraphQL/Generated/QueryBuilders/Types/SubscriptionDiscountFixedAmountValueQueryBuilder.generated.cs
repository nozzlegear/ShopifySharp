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
    public sealed class SubscriptionDiscountFixedAmountValueQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountFixedAmountValue, SubscriptionDiscountFixedAmountValueQueryBuilder>
    {
        protected override SubscriptionDiscountFixedAmountValueQueryBuilder Self => this;

        public SubscriptionDiscountFixedAmountValueQueryBuilder() : this("subscriptionDiscountFixedAmountValue")
        {
        }

        public SubscriptionDiscountFixedAmountValueQueryBuilder(string name) : base(new Query<SubscriptionDiscountFixedAmountValue>(name))
        {
        }

        public SubscriptionDiscountFixedAmountValueQueryBuilder(IQuery<SubscriptionDiscountFixedAmountValue> query) : base(query)
        {
        }

        public SubscriptionDiscountFixedAmountValueQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionDiscountFixedAmountValueQueryBuilder AppliesOnEachItem()
        {
            base.InnerQuery.AddField("appliesOnEachItem");
            return this;
        }
    }
}