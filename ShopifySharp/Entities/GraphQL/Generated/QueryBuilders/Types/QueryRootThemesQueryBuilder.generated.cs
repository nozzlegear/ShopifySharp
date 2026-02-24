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
    public sealed class QueryRootThemesQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeConnection, QueryRootThemesQueryBuilder>, IHasArguments<QueryRootThemesArgumentsBuilder>
    {
        public QueryRootThemesArgumentsBuilder Arguments { get; }
        protected override QueryRootThemesQueryBuilder Self => this;

        public QueryRootThemesQueryBuilder(string name) : base(new Query<OnlineStoreThemeConnection>(name))
        {
            Arguments = new QueryRootThemesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootThemesQueryBuilder(IQuery<OnlineStoreThemeConnection> query) : base(query)
        {
            Arguments = new QueryRootThemesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootThemesQueryBuilder SetArguments(Action<QueryRootThemesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootThemesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeEdgeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeEdge>(query);
            return this;
        }

        public QueryRootThemesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public QueryRootThemesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}