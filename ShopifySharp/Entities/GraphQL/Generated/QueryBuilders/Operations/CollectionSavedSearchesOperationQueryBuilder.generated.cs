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
    public sealed class CollectionSavedSearchesOperationQueryBuilder : FieldsQueryBuilderBase<SavedSearchConnection, CollectionSavedSearchesOperationQueryBuilder>, IGraphOperationQueryBuilder<SavedSearchConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CollectionSavedSearchesArgumentsBuilder Arguments { get; }
        protected override CollectionSavedSearchesOperationQueryBuilder Self => this;

        public CollectionSavedSearchesOperationQueryBuilder() : this("collectionSavedSearches")
        {
        }

        public CollectionSavedSearchesOperationQueryBuilder(string name) : base(new Query<SavedSearchConnection>(name))
        {
            Arguments = new CollectionSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public CollectionSavedSearchesOperationQueryBuilder(IQuery<SavedSearchConnection> query) : base(query)
        {
            Arguments = new CollectionSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public CollectionSavedSearchesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchEdgeQueryBuilder> build)
        {
            var query = new Query<SavedSearchEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchEdge>(query);
            return this;
        }

        public CollectionSavedSearchesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }

        public CollectionSavedSearchesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}