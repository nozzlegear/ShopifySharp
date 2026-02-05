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
    public sealed class AppUsageRecordCreatePayloadQueryBuilder : FieldsQueryBuilderBase<AppUsageRecordCreatePayload, AppUsageRecordCreatePayloadQueryBuilder>
    {
        protected override AppUsageRecordCreatePayloadQueryBuilder Self => this;

        public AppUsageRecordCreatePayloadQueryBuilder() : this("appUsageRecordCreatePayload")
        {
        }

        public AppUsageRecordCreatePayloadQueryBuilder(string name) : base(new Query<AppUsageRecordCreatePayload>(name))
        {
        }

        public AppUsageRecordCreatePayloadQueryBuilder(IQuery<AppUsageRecordCreatePayload> query) : base(query)
        {
        }

        public AppUsageRecordCreatePayloadQueryBuilder AppUsageRecord(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordQueryBuilder> build)
        {
            var query = new Query<AppUsageRecord>("appUsageRecord");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecord>(query);
            return this;
        }

        public AppUsageRecordCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}