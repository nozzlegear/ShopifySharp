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
    public sealed class UrlRedirectsOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectConnection, UrlRedirectsOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public UrlRedirectsArgumentsBuilder Arguments { get; }
        protected override UrlRedirectsOperationQueryBuilder Self => this;

        public UrlRedirectsOperationQueryBuilder() : this("urlRedirects")
        {
        }

        public UrlRedirectsOperationQueryBuilder(string name) : base(new Query<UrlRedirectConnection>(name))
        {
            Arguments = new UrlRedirectsArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectsOperationQueryBuilder(IQuery<UrlRedirectConnection> query) : base(query)
        {
            Arguments = new UrlRedirectsArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectEdgeQueryBuilder> build)
        {
            var query = new Query<UrlRedirectEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectEdge>(query);
            return this;
        }

        public UrlRedirectsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public UrlRedirectsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}