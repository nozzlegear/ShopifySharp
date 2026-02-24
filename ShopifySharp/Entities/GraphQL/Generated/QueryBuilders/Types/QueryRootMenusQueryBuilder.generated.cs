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
    public sealed class QueryRootMenusQueryBuilder : FieldsQueryBuilderBase<MenuConnection, QueryRootMenusQueryBuilder>, IHasArguments<QueryRootMenusArgumentsBuilder>
    {
        public QueryRootMenusArgumentsBuilder Arguments { get; }
        protected override QueryRootMenusQueryBuilder Self => this;

        public QueryRootMenusQueryBuilder(string name) : base(new Query<MenuConnection>(name))
        {
            Arguments = new QueryRootMenusArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMenusQueryBuilder(IQuery<MenuConnection> query) : base(query)
        {
            Arguments = new QueryRootMenusArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMenusQueryBuilder SetArguments(Action<QueryRootMenusArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMenusQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuEdgeQueryBuilder> build)
        {
            var query = new Query<MenuEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuEdge>(query);
            return this;
        }

        public QueryRootMenusQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public QueryRootMenusQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}