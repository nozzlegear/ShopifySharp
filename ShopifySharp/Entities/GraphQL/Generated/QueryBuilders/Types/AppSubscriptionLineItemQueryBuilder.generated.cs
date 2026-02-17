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
    public sealed class AppSubscriptionLineItemQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionLineItem, AppSubscriptionLineItemQueryBuilder>
    {
        protected override AppSubscriptionLineItemQueryBuilder Self => this;

        public AppSubscriptionLineItemQueryBuilder() : this("appSubscriptionLineItem")
        {
        }

        public AppSubscriptionLineItemQueryBuilder(string name) : base(new Query<AppSubscriptionLineItem>(name))
        {
        }

        public AppSubscriptionLineItemQueryBuilder(IQuery<AppSubscriptionLineItem> query) : base(query)
        {
        }

        public AppSubscriptionLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppSubscriptionLineItemQueryBuilder Plan(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPlanV2QueryBuilder> build)
        {
            var query = new Query<AppPlanV2>("plan");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPlanV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPlanV2>(query);
            return this;
        }

        public AppSubscriptionLineItemQueryBuilder UsageRecords(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordConnectionQueryBuilder> build)
        {
            var query = new Query<AppUsageRecordConnection>("usageRecords");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecordConnection>(query);
            return this;
        }
    }
}