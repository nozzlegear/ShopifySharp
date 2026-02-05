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
    public sealed class AppUsageRecordConnectionQueryBuilder : FieldsQueryBuilderBase<AppUsageRecordConnection, AppUsageRecordConnectionQueryBuilder>
    {
        protected override AppUsageRecordConnectionQueryBuilder Self => this;

        public AppUsageRecordConnectionQueryBuilder() : this("appUsageRecordConnection")
        {
        }

        public AppUsageRecordConnectionQueryBuilder(string name) : base(new Query<AppUsageRecordConnection>(name))
        {
        }

        public AppUsageRecordConnectionQueryBuilder(IQuery<AppUsageRecordConnection> query) : base(query)
        {
        }

        public AppUsageRecordConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordEdgeQueryBuilder> build)
        {
            var query = new Query<AppUsageRecordEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecordEdge>(query);
            return this;
        }

        public AppUsageRecordConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordQueryBuilder> build)
        {
            var query = new Query<AppUsageRecord>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUsageRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecord>(query);
            return this;
        }

        public AppUsageRecordConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}