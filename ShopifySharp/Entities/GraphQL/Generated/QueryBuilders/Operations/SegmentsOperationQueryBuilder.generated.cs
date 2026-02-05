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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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

        public SegmentsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentEdge>(query);
            return this;
        }

        public SegmentsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public SegmentsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}