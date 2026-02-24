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
    public sealed class AppInstallationRevenueAttributionRecordsQueryBuilder : FieldsQueryBuilderBase<AppRevenueAttributionRecordConnection, AppInstallationRevenueAttributionRecordsQueryBuilder>, IHasArguments<AppInstallationRevenueAttributionRecordsArgumentsBuilder>
    {
        public AppInstallationRevenueAttributionRecordsArgumentsBuilder Arguments { get; }
        protected override AppInstallationRevenueAttributionRecordsQueryBuilder Self => this;

        public AppInstallationRevenueAttributionRecordsQueryBuilder(string name) : base(new Query<AppRevenueAttributionRecordConnection>(name))
        {
            Arguments = new AppInstallationRevenueAttributionRecordsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationRevenueAttributionRecordsQueryBuilder(IQuery<AppRevenueAttributionRecordConnection> query) : base(query)
        {
            Arguments = new AppInstallationRevenueAttributionRecordsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationRevenueAttributionRecordsQueryBuilder SetArguments(Action<AppInstallationRevenueAttributionRecordsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordEdgeQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecordEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecordEdge>(query);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecord>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecord>(query);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}