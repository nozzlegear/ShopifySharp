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
    public sealed class QueryRootDraftOrdersQueryBuilder : FieldsQueryBuilderBase<DraftOrderConnection, QueryRootDraftOrdersQueryBuilder>, IHasArguments<QueryRootDraftOrdersArgumentsBuilder>
    {
        public QueryRootDraftOrdersArgumentsBuilder Arguments { get; }
        protected override QueryRootDraftOrdersQueryBuilder Self => this;

        public QueryRootDraftOrdersQueryBuilder(string name) : base(new Query<DraftOrderConnection>(name))
        {
            Arguments = new QueryRootDraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDraftOrdersQueryBuilder(IQuery<DraftOrderConnection> query) : base(query)
        {
            Arguments = new QueryRootDraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDraftOrdersQueryBuilder SetArguments(Action<QueryRootDraftOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDraftOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderEdgeQueryBuilder> build)
        {
            var query = new Query<DraftOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderEdge>(query);
            return this;
        }

        public QueryRootDraftOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public QueryRootDraftOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}