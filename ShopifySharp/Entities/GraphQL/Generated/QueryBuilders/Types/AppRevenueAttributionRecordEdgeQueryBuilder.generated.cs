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
    public sealed class AppRevenueAttributionRecordEdgeQueryBuilder : FieldsQueryBuilderBase<AppRevenueAttributionRecordEdge, AppRevenueAttributionRecordEdgeQueryBuilder>
    {
        protected override AppRevenueAttributionRecordEdgeQueryBuilder Self => this;

        public AppRevenueAttributionRecordEdgeQueryBuilder() : this("appRevenueAttributionRecordEdge")
        {
        }

        public AppRevenueAttributionRecordEdgeQueryBuilder(string name) : base(new Query<AppRevenueAttributionRecordEdge>(name))
        {
        }

        public AppRevenueAttributionRecordEdgeQueryBuilder(IQuery<AppRevenueAttributionRecordEdge> query) : base(query)
        {
        }

        public AppRevenueAttributionRecordEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppRevenueAttributionRecordEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecord>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecord>(query);
            return this;
        }
    }
}