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
    public sealed class AppRevenueAttributionRecordQueryBuilder : FieldsQueryBuilderBase<AppRevenueAttributionRecord, AppRevenueAttributionRecordQueryBuilder>
    {
        protected override AppRevenueAttributionRecordQueryBuilder Self => this;

        public AppRevenueAttributionRecordQueryBuilder() : this("appRevenueAttributionRecord")
        {
        }

        public AppRevenueAttributionRecordQueryBuilder(string name) : base(new Query<AppRevenueAttributionRecord>(name))
        {
        }

        public AppRevenueAttributionRecordQueryBuilder(IQuery<AppRevenueAttributionRecord> query) : base(query)
        {
        }

        public AppRevenueAttributionRecordQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppRevenueAttributionRecordQueryBuilder CapturedAt()
        {
            base.InnerQuery.AddField("capturedAt");
            return this;
        }

        public AppRevenueAttributionRecordQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AppRevenueAttributionRecordQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppRevenueAttributionRecordQueryBuilder IdempotencyKey()
        {
            base.InnerQuery.AddField("idempotencyKey");
            return this;
        }

        public AppRevenueAttributionRecordQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        public AppRevenueAttributionRecordQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}