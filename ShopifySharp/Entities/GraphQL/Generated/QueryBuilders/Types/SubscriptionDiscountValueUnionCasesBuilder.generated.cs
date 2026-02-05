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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SubscriptionDiscountValueUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionDiscountValue, SubscriptionDiscountValueUnionCasesBuilder>
    {
        protected override SubscriptionDiscountValueUnionCasesBuilder Self => this;

        public SubscriptionDiscountValueUnionCasesBuilder(string fieldName = "value") : this(new Query<SubscriptionDiscountValue>(fieldName))
        {
        }

        public SubscriptionDiscountValueUnionCasesBuilder(IQuery<SubscriptionDiscountValue> query) : base(query)
        {
        }

        public SubscriptionDiscountValueUnionCasesBuilder OnSubscriptionDiscountFixedAmountValue(Action<SubscriptionDiscountFixedAmountValueQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountFixedAmountValue>("... on SubscriptionDiscountFixedAmountValue");
            var queryBuilder = new SubscriptionDiscountFixedAmountValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionDiscountValueUnionCasesBuilder OnSubscriptionDiscountPercentageValue(Action<SubscriptionDiscountPercentageValueQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountPercentageValue>("... on SubscriptionDiscountPercentageValue");
            var queryBuilder = new SubscriptionDiscountPercentageValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}