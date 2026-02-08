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
    public sealed class AutomaticDiscountSavedSearchesOperationQueryBuilder : FieldsQueryBuilderBase<SavedSearchConnection, AutomaticDiscountSavedSearchesOperationQueryBuilder>, IGraphOperationQueryBuilder<SavedSearchConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AutomaticDiscountSavedSearchesArgumentsBuilder Arguments { get; }
        protected override AutomaticDiscountSavedSearchesOperationQueryBuilder Self => this;

        public AutomaticDiscountSavedSearchesOperationQueryBuilder() : this("automaticDiscountSavedSearches")
        {
        }

        public AutomaticDiscountSavedSearchesOperationQueryBuilder(string name) : base(new Query<SavedSearchConnection>(name))
        {
            Arguments = new AutomaticDiscountSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountSavedSearchesOperationQueryBuilder(IQuery<SavedSearchConnection> query) : base(query)
        {
            Arguments = new AutomaticDiscountSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountSavedSearchesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchEdgeQueryBuilder> build)
        {
            var query = new Query<SavedSearchEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchEdge>(query);
            return this;
        }

        public AutomaticDiscountSavedSearchesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }

        public AutomaticDiscountSavedSearchesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}