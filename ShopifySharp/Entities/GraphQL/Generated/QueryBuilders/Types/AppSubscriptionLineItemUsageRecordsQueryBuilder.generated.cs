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
    public sealed class AppSubscriptionLineItemUsageRecordsQueryBuilder : FieldsQueryBuilderBase<AppUsageRecordConnection, AppSubscriptionLineItemUsageRecordsQueryBuilder>, IHasArguments<AppSubscriptionLineItemUsageRecordsArgumentsBuilder>
    {
        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder Arguments { get; }
        protected override AppSubscriptionLineItemUsageRecordsQueryBuilder Self => this;

        public AppSubscriptionLineItemUsageRecordsQueryBuilder(string name) : base(new Query<AppUsageRecordConnection>(name))
        {
            Arguments = new AppSubscriptionLineItemUsageRecordsArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionLineItemUsageRecordsQueryBuilder(IQuery<AppUsageRecordConnection> query) : base(query)
        {
            Arguments = new AppSubscriptionLineItemUsageRecordsArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionLineItemUsageRecordsQueryBuilder SetArguments(Action<AppSubscriptionLineItemUsageRecordsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordEdgeQueryBuilder> build)
        {
            var query = new Query<AppUsageRecordEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecordEdge>(query);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordQueryBuilder> build)
        {
            var query = new Query<AppUsageRecord>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecord>(query);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}