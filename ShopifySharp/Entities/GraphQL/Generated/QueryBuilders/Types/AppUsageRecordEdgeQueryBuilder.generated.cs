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
    public sealed class AppUsageRecordEdgeQueryBuilder : FieldsQueryBuilderBase<AppUsageRecordEdge, AppUsageRecordEdgeQueryBuilder>
    {
        protected override AppUsageRecordEdgeQueryBuilder Self => this;

        public AppUsageRecordEdgeQueryBuilder() : this("appUsageRecordEdge")
        {
        }

        public AppUsageRecordEdgeQueryBuilder(string name) : base(new Query<AppUsageRecordEdge>(name))
        {
        }

        public AppUsageRecordEdgeQueryBuilder(IQuery<AppUsageRecordEdge> query) : base(query)
        {
        }

        public AppUsageRecordEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppUsageRecordEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordQueryBuilder> build)
        {
            var query = new Query<AppUsageRecord>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppUsageRecordQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUsageRecord>(query);
            return this;
        }
    }
}