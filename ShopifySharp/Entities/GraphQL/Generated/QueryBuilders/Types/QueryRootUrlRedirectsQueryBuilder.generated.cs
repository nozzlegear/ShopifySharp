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
    public sealed class QueryRootUrlRedirectsQueryBuilder : FieldsQueryBuilderBase<UrlRedirectConnection, QueryRootUrlRedirectsQueryBuilder>, IHasArguments<QueryRootUrlRedirectsArgumentsBuilder>
    {
        public QueryRootUrlRedirectsArgumentsBuilder Arguments { get; }
        protected override QueryRootUrlRedirectsQueryBuilder Self => this;

        public QueryRootUrlRedirectsQueryBuilder(string name) : base(new Query<UrlRedirectConnection>(name))
        {
            Arguments = new QueryRootUrlRedirectsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectsQueryBuilder(IQuery<UrlRedirectConnection> query) : base(query)
        {
            Arguments = new QueryRootUrlRedirectsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectsQueryBuilder SetArguments(Action<QueryRootUrlRedirectsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootUrlRedirectsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectEdgeQueryBuilder> build)
        {
            var query = new Query<UrlRedirectEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectEdge>(query);
            return this;
        }

        public QueryRootUrlRedirectsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public QueryRootUrlRedirectsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}