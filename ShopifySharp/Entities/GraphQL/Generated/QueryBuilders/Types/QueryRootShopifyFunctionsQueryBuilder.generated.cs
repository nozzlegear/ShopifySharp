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
    public sealed class QueryRootShopifyFunctionsQueryBuilder : FieldsQueryBuilderBase<ShopifyFunctionConnection, QueryRootShopifyFunctionsQueryBuilder>, IHasArguments<QueryRootShopifyFunctionsArgumentsBuilder>
    {
        public QueryRootShopifyFunctionsArgumentsBuilder Arguments { get; }
        protected override QueryRootShopifyFunctionsQueryBuilder Self => this;

        public QueryRootShopifyFunctionsQueryBuilder(string name) : base(new Query<ShopifyFunctionConnection>(name))
        {
            Arguments = new QueryRootShopifyFunctionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopifyFunctionsQueryBuilder(IQuery<ShopifyFunctionConnection> query) : base(query)
        {
            Arguments = new QueryRootShopifyFunctionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopifyFunctionsQueryBuilder SetArguments(Action<QueryRootShopifyFunctionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootShopifyFunctionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyFunctionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunctionEdge>(query);
            return this;
        }

        public QueryRootShopifyFunctionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public QueryRootShopifyFunctionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}