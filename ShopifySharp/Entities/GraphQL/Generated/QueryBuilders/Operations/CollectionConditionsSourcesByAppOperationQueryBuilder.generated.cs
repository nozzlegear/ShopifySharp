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
    public sealed class CollectionConditionsSourcesByAppOperationQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourcesByAppConnection, CollectionConditionsSourcesByAppOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionConditionsSourcesByAppConnection>, IHasArguments<CollectionConditionsSourcesByAppArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CollectionConditionsSourcesByAppArgumentsBuilder Arguments { get; }
        protected override CollectionConditionsSourcesByAppOperationQueryBuilder Self => this;

        public CollectionConditionsSourcesByAppOperationQueryBuilder() : this("collectionConditionsSourcesByApp")
        {
        }

        public CollectionConditionsSourcesByAppOperationQueryBuilder(string name) : base(new Query<CollectionConditionsSourcesByAppConnection>(name))
        {
            Arguments = new CollectionConditionsSourcesByAppArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourcesByAppOperationQueryBuilder(IQuery<CollectionConditionsSourcesByAppConnection> query) : base(query)
        {
            Arguments = new CollectionConditionsSourcesByAppArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourcesByAppOperationQueryBuilder SetArguments(Action<CollectionConditionsSourcesByAppArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionConditionsSourcesByAppOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourcesByAppEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourcesByAppEdge>(query);
            return this;
        }

        public CollectionConditionsSourcesByAppOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourcesByApp>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourcesByApp>(query);
            return this;
        }

        public CollectionConditionsSourcesByAppOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}