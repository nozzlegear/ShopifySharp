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
    public sealed class AppSubscriptionDiscountQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionDiscount, AppSubscriptionDiscountQueryBuilder>
    {
        protected override AppSubscriptionDiscountQueryBuilder Self => this;

        public AppSubscriptionDiscountQueryBuilder() : this("appSubscriptionDiscount")
        {
        }

        public AppSubscriptionDiscountQueryBuilder(string name) : base(new Query<AppSubscriptionDiscount>(name))
        {
        }

        public AppSubscriptionDiscountQueryBuilder(IQuery<AppSubscriptionDiscount> query) : base(query)
        {
        }

        public AppSubscriptionDiscountQueryBuilder DurationLimitInIntervals()
        {
            base.InnerQuery.AddField("durationLimitInIntervals");
            return this;
        }

        public AppSubscriptionDiscountQueryBuilder PriceAfterDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("priceAfterDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppSubscriptionDiscountQueryBuilder RemainingDurationInIntervals()
        {
            base.InnerQuery.AddField("remainingDurationInIntervals");
            return this;
        }

        public AppSubscriptionDiscountQueryBuilder Value(Action<AppSubscriptionDiscountValueUnionCasesBuilder> build)
        {
            var query = new Query<AppSubscriptionDiscountValue>("value");
            var unionBuilder = new AppSubscriptionDiscountValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}