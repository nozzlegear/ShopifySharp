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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootCollectionConditionsSourcesByAppQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourcesByAppConnection, QueryRootCollectionConditionsSourcesByAppQueryBuilder>, IHasArguments<QueryRootCollectionConditionsSourcesByAppArgumentsBuilder>
    {
        public QueryRootCollectionConditionsSourcesByAppArgumentsBuilder Arguments { get; }
        protected override QueryRootCollectionConditionsSourcesByAppQueryBuilder Self => this;

        public QueryRootCollectionConditionsSourcesByAppQueryBuilder(string name) : base(new Query<CollectionConditionsSourcesByAppConnection>(name))
        {
            Arguments = new QueryRootCollectionConditionsSourcesByAppArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCollectionConditionsSourcesByAppQueryBuilder(IQuery<CollectionConditionsSourcesByAppConnection> query) : base(query)
        {
            Arguments = new QueryRootCollectionConditionsSourcesByAppArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCollectionConditionsSourcesByAppQueryBuilder SetArguments(Action<QueryRootCollectionConditionsSourcesByAppArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCollectionConditionsSourcesByAppQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourcesByAppEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourcesByAppEdge>(query);
            return this;
        }

        public QueryRootCollectionConditionsSourcesByAppQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourcesByApp>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourcesByApp>(query);
            return this;
        }

        public QueryRootCollectionConditionsSourcesByAppQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}