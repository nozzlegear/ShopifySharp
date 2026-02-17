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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class SegmentFiltersOperationQueryBuilder : FieldsQueryBuilderBase<SegmentFilterConnection, SegmentFiltersOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentFilterConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SegmentFiltersArgumentsBuilder Arguments { get; }
        protected override SegmentFiltersOperationQueryBuilder Self => this;

        public SegmentFiltersOperationQueryBuilder() : this("segmentFilters")
        {
        }

        public SegmentFiltersOperationQueryBuilder(string name) : base(new Query<SegmentFilterConnection>(name))
        {
            Arguments = new SegmentFiltersArgumentsBuilder(base.InnerQuery);
        }

        public SegmentFiltersOperationQueryBuilder(IQuery<SegmentFilterConnection> query) : base(query)
        {
            Arguments = new SegmentFiltersArgumentsBuilder(base.InnerQuery);
        }

        public SegmentFiltersOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentFilterEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentFilterEdge>(query);
            return this;
        }

        public SegmentFiltersOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder> build)
        {
            var query = new Query<ISegmentFilter>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISegmentFilter>(query);
            return this;
        }

        public SegmentFiltersOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}