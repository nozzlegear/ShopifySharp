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
    public sealed class QueryRootCatalogsQueryBuilder : FieldsQueryBuilderBase<CatalogConnection, QueryRootCatalogsQueryBuilder>, IHasArguments<QueryRootCatalogsArgumentsBuilder>
    {
        public QueryRootCatalogsArgumentsBuilder Arguments { get; }
        protected override QueryRootCatalogsQueryBuilder Self => this;

        public QueryRootCatalogsQueryBuilder(string name) : base(new Query<CatalogConnection>(name))
        {
            Arguments = new QueryRootCatalogsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCatalogsQueryBuilder(IQuery<CatalogConnection> query) : base(query)
        {
            Arguments = new QueryRootCatalogsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCatalogsQueryBuilder SetArguments(Action<QueryRootCatalogsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCatalogsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogEdgeQueryBuilder> build)
        {
            var query = new Query<CatalogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogEdge>(query);
            return this;
        }

        public QueryRootCatalogsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public QueryRootCatalogsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}