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
    public sealed class AppUsageRecordCreateOperationQueryBuilder : FieldsQueryBuilderBase<AppUsageRecordCreatePayload, AppUsageRecordCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<AppUsageRecordCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AppUsageRecordCreateArgumentsBuilder Arguments { get; }
        protected override AppUsageRecordCreateOperationQueryBuilder Self => this;

        public AppUsageRecordCreateOperationQueryBuilder() : this("appUsageRecordCreate")
        {
        }

        public AppUsageRecordCreateOperationQueryBuilder(string name) : base(new Query<AppUsageRecordCreatePayload>(name))
        {
            Arguments = new AppUsageRecordCreateArgumentsBuilder(base.InnerQuery);
        }

        public AppUsageRecordCreateOperationQueryBuilder(IQuery<AppUsageRecordCreatePayload> query) : base(query)
        {
            Arguments = new AppUsageRecordCreateArgumentsBuilder(base.InnerQuery);
        }

        public AppUsageRecordCreateOperationQueryBuilder AppUsageRecord(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordQueryBuilder> build)
        {
            var query = new Query<AppUsageRecord>("appUsageRecord");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecord>(query);
            return this;
        }

        public AppUsageRecordCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}