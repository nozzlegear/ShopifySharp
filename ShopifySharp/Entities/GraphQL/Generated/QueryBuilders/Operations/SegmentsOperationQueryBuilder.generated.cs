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
    public sealed class SegmentsOperationQueryBuilder : FieldsQueryBuilderBase<SegmentConnection, SegmentsOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SegmentsArgumentsBuilder Arguments { get; }
        protected override SegmentsOperationQueryBuilder Self => this;

        public SegmentsOperationQueryBuilder() : this("segments")
        {
        }

        public SegmentsOperationQueryBuilder(string name) : base(new Query<SegmentConnection>(name))
        {
            Arguments = new SegmentsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentsOperationQueryBuilder(IQuery<SegmentConnection> query) : base(query)
        {
            Arguments = new SegmentsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentEdge>(query);
            return this;
        }

        public SegmentsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public SegmentsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}