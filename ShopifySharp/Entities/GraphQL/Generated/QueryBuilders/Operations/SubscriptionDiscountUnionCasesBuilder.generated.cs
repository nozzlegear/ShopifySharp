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
    public sealed class SubscriptionDiscountUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionDiscount, SubscriptionDiscountUnionCasesBuilder>
    {
        protected override SubscriptionDiscountUnionCasesBuilder Self => this;

        public SubscriptionDiscountUnionCasesBuilder(string fieldName = "discountRemoved") : this(new Query<SubscriptionDiscount>(fieldName))
        {
        }

        public SubscriptionDiscountUnionCasesBuilder(IQuery<SubscriptionDiscount> query) : base(query)
        {
        }

        public SubscriptionDiscountUnionCasesBuilder OnSubscriptionAppliedCodeDiscount(Action<SubscriptionAppliedCodeDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionAppliedCodeDiscount>("... on SubscriptionAppliedCodeDiscount");
            var queryBuilder = new SubscriptionAppliedCodeDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionDiscountUnionCasesBuilder OnSubscriptionManualDiscount(Action<SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("... on SubscriptionManualDiscount");
            var queryBuilder = new SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}