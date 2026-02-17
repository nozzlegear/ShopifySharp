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
    public sealed class AppUsageRecordQueryBuilder : FieldsQueryBuilderBase<AppUsageRecord, AppUsageRecordQueryBuilder>
    {
        protected override AppUsageRecordQueryBuilder Self => this;

        public AppUsageRecordQueryBuilder() : this("appUsageRecord")
        {
        }

        public AppUsageRecordQueryBuilder(string name) : base(new Query<AppUsageRecord>(name))
        {
        }

        public AppUsageRecordQueryBuilder(IQuery<AppUsageRecord> query) : base(query)
        {
        }

        public AppUsageRecordQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AppUsageRecordQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public AppUsageRecordQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppUsageRecordQueryBuilder IdempotencyKey()
        {
            base.InnerQuery.AddField("idempotencyKey");
            return this;
        }

        public AppUsageRecordQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppUsageRecordQueryBuilder SubscriptionLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionLineItemQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionLineItem>("subscriptionLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionLineItem>(query);
            return this;
        }
    }
}