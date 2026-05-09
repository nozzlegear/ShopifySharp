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
    public sealed class QueryRootCashDrawersQueryBuilder : FieldsQueryBuilderBase<CashDrawerConnection, QueryRootCashDrawersQueryBuilder>, IHasArguments<QueryRootCashDrawersArgumentsBuilder>
    {
        public QueryRootCashDrawersArgumentsBuilder Arguments { get; }
        protected override QueryRootCashDrawersQueryBuilder Self => this;

        public QueryRootCashDrawersQueryBuilder(string name) : base(new Query<CashDrawerConnection>(name))
        {
            Arguments = new QueryRootCashDrawersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashDrawersQueryBuilder(IQuery<CashDrawerConnection> query) : base(query)
        {
            Arguments = new QueryRootCashDrawersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashDrawersQueryBuilder SetArguments(Action<QueryRootCashDrawersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCashDrawersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerEdgeQueryBuilder> build)
        {
            var query = new Query<CashDrawerEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawerEdge>(query);
            return this;
        }

        public QueryRootCashDrawersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public QueryRootCashDrawersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}