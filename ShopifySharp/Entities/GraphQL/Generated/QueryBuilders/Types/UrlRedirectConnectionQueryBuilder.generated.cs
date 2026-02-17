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
    public sealed class UrlRedirectConnectionQueryBuilder : FieldsQueryBuilderBase<UrlRedirectConnection, UrlRedirectConnectionQueryBuilder>
    {
        protected override UrlRedirectConnectionQueryBuilder Self => this;

        public UrlRedirectConnectionQueryBuilder() : this("urlRedirectConnection")
        {
        }

        public UrlRedirectConnectionQueryBuilder(string name) : base(new Query<UrlRedirectConnection>(name))
        {
        }

        public UrlRedirectConnectionQueryBuilder(IQuery<UrlRedirectConnection> query) : base(query)
        {
        }

        public UrlRedirectConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectEdgeQueryBuilder> build)
        {
            var query = new Query<UrlRedirectEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectEdge>(query);
            return this;
        }

        public UrlRedirectConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public UrlRedirectConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}