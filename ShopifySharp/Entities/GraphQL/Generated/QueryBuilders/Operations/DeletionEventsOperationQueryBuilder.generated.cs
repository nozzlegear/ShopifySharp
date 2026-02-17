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
    [Obsolete("Use `events` instead.")]
    public sealed class DeletionEventsOperationQueryBuilder : FieldsQueryBuilderBase<DeletionEventConnection, DeletionEventsOperationQueryBuilder>, IGraphOperationQueryBuilder<DeletionEventConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DeletionEventsArgumentsBuilder Arguments { get; }
        protected override DeletionEventsOperationQueryBuilder Self => this;

        public DeletionEventsOperationQueryBuilder() : this("deletionEvents")
        {
        }

        public DeletionEventsOperationQueryBuilder(string name) : base(new Query<DeletionEventConnection>(name))
        {
            Arguments = new DeletionEventsArgumentsBuilder(base.InnerQuery);
        }

        public DeletionEventsOperationQueryBuilder(IQuery<DeletionEventConnection> query) : base(query)
        {
            Arguments = new DeletionEventsArgumentsBuilder(base.InnerQuery);
        }

        public DeletionEventsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventEdgeQueryBuilder> build)
        {
            var query = new Query<DeletionEventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeletionEventEdge>(query);
            return this;
        }

        public DeletionEventsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventQueryBuilder> build)
        {
            var query = new Query<DeletionEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeletionEvent>(query);
            return this;
        }

        public DeletionEventsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}