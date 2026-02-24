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
    public sealed class QueryRootPagesQueryBuilder : FieldsQueryBuilderBase<PageConnection, QueryRootPagesQueryBuilder>, IHasArguments<QueryRootPagesArgumentsBuilder>
    {
        public QueryRootPagesArgumentsBuilder Arguments { get; }
        protected override QueryRootPagesQueryBuilder Self => this;

        public QueryRootPagesQueryBuilder(string name) : base(new Query<PageConnection>(name))
        {
            Arguments = new QueryRootPagesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPagesQueryBuilder(IQuery<PageConnection> query) : base(query)
        {
            Arguments = new QueryRootPagesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPagesQueryBuilder SetArguments(Action<QueryRootPagesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPagesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageEdgeQueryBuilder> build)
        {
            var query = new Query<PageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageEdge>(query);
            return this;
        }

        public QueryRootPagesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }

        public QueryRootPagesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}