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
    public sealed class QueryRootCustomersQueryBuilder : FieldsQueryBuilderBase<CustomerConnection, QueryRootCustomersQueryBuilder>, IHasArguments<QueryRootCustomersArgumentsBuilder>
    {
        public QueryRootCustomersArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomersQueryBuilder Self => this;

        public QueryRootCustomersQueryBuilder(string name) : base(new Query<CustomerConnection>(name))
        {
            Arguments = new QueryRootCustomersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomersQueryBuilder(IQuery<CustomerConnection> query) : base(query)
        {
            Arguments = new QueryRootCustomersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomersQueryBuilder SetArguments(Action<QueryRootCustomersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEdge>(query);
            return this;
        }

        public QueryRootCustomersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootCustomersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}