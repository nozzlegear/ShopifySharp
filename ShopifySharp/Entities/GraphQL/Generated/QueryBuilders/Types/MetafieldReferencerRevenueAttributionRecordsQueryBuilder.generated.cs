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
    public sealed class MetafieldReferencerRevenueAttributionRecordsQueryBuilder : FieldsQueryBuilderBase<AppRevenueAttributionRecordConnection, MetafieldReferencerRevenueAttributionRecordsQueryBuilder>, IHasArguments<MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder>
    {
        public MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerRevenueAttributionRecordsQueryBuilder Self => this;

        public MetafieldReferencerRevenueAttributionRecordsQueryBuilder(string name) : base(new Query<AppRevenueAttributionRecordConnection>(name))
        {
            Arguments = new MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRevenueAttributionRecordsQueryBuilder(IQuery<AppRevenueAttributionRecordConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRevenueAttributionRecordsQueryBuilder SetArguments(Action<MetafieldReferencerRevenueAttributionRecordsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordEdgeQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecordEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecordEdge>(query);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecord>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecord>(query);
            return this;
        }

        public MetafieldReferencerRevenueAttributionRecordsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}