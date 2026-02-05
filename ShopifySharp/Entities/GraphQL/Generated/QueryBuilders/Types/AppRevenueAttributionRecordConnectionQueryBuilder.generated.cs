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
    public sealed class AppRevenueAttributionRecordConnectionQueryBuilder : FieldsQueryBuilderBase<AppRevenueAttributionRecordConnection, AppRevenueAttributionRecordConnectionQueryBuilder>
    {
        protected override AppRevenueAttributionRecordConnectionQueryBuilder Self => this;

        public AppRevenueAttributionRecordConnectionQueryBuilder() : this("appRevenueAttributionRecordConnection")
        {
        }

        public AppRevenueAttributionRecordConnectionQueryBuilder(string name) : base(new Query<AppRevenueAttributionRecordConnection>(name))
        {
        }

        public AppRevenueAttributionRecordConnectionQueryBuilder(IQuery<AppRevenueAttributionRecordConnection> query) : base(query)
        {
        }

        public AppRevenueAttributionRecordConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordEdgeQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecordEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecordEdge>(query);
            return this;
        }

        public AppRevenueAttributionRecordConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecord>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecord>(query);
            return this;
        }

        public AppRevenueAttributionRecordConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}