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
    public sealed class SegmentFilterSuggestionsOperationQueryBuilder : FieldsQueryBuilderBase<SegmentFilterConnection, SegmentFilterSuggestionsOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentFilterConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SegmentFilterSuggestionsArgumentsBuilder Arguments { get; }
        protected override SegmentFilterSuggestionsOperationQueryBuilder Self => this;

        public SegmentFilterSuggestionsOperationQueryBuilder() : this("segmentFilterSuggestions")
        {
        }

        public SegmentFilterSuggestionsOperationQueryBuilder(string name) : base(new Query<SegmentFilterConnection>(name))
        {
            Arguments = new SegmentFilterSuggestionsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentFilterSuggestionsOperationQueryBuilder(IQuery<SegmentFilterConnection> query) : base(query)
        {
            Arguments = new SegmentFilterSuggestionsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentFilterSuggestionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentFilterEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentFilterEdge>(query);
            return this;
        }

        public SegmentFilterSuggestionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder> build)
        {
            var query = new Query<ISegmentFilter>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISegmentFilter>(query);
            return this;
        }

        public SegmentFilterSuggestionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}