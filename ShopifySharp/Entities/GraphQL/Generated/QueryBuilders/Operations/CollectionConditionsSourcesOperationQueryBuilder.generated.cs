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
    public sealed class CollectionConditionsSourcesOperationQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourceConnection, CollectionConditionsSourcesOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionConditionsSourceConnection>, IHasArguments<CollectionConditionsSourcesArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CollectionConditionsSourcesArgumentsBuilder Arguments { get; }
        protected override CollectionConditionsSourcesOperationQueryBuilder Self => this;

        public CollectionConditionsSourcesOperationQueryBuilder() : this("collectionConditionsSources")
        {
        }

        public CollectionConditionsSourcesOperationQueryBuilder(string name) : base(new Query<CollectionConditionsSourceConnection>(name))
        {
            Arguments = new CollectionConditionsSourcesArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourcesOperationQueryBuilder(IQuery<CollectionConditionsSourceConnection> query) : base(query)
        {
            Arguments = new CollectionConditionsSourcesArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourcesOperationQueryBuilder SetArguments(Action<CollectionConditionsSourcesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionConditionsSourcesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourceEdge>(query);
            return this;
        }

        public CollectionConditionsSourcesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSource>(query);
            return this;
        }

        public CollectionConditionsSourcesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}