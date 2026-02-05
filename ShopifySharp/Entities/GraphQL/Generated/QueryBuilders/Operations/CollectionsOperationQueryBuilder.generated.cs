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
    public sealed class CollectionsOperationQueryBuilder : FieldsQueryBuilderBase<CollectionConnection, CollectionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CollectionsArgumentsBuilder Arguments { get; }
        protected override CollectionsOperationQueryBuilder Self => this;

        public CollectionsOperationQueryBuilder() : this("collections")
        {
        }

        public CollectionsOperationQueryBuilder(string name) : base(new Query<CollectionConnection>(name))
        {
            Arguments = new CollectionsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionsOperationQueryBuilder(IQuery<CollectionConnection> query) : base(query)
        {
            Arguments = new CollectionsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionEdge>(query);
            return this;
        }

        public CollectionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}