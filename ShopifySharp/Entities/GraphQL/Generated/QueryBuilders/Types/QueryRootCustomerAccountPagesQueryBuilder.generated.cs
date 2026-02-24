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
    public sealed class QueryRootCustomerAccountPagesQueryBuilder : FieldsQueryBuilderBase<CustomerAccountPageConnection, QueryRootCustomerAccountPagesQueryBuilder>, IHasArguments<QueryRootCustomerAccountPagesArgumentsBuilder>
    {
        public QueryRootCustomerAccountPagesArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerAccountPagesQueryBuilder Self => this;

        public QueryRootCustomerAccountPagesQueryBuilder(string name) : base(new Query<CustomerAccountPageConnection>(name))
        {
            Arguments = new QueryRootCustomerAccountPagesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerAccountPagesQueryBuilder(IQuery<CustomerAccountPageConnection> query) : base(query)
        {
            Arguments = new QueryRootCustomerAccountPagesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerAccountPagesQueryBuilder SetArguments(Action<QueryRootCustomerAccountPagesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerAccountPagesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerAccountPageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerAccountPageEdge>(query);
            return this;
        }

        public QueryRootCustomerAccountPagesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageQueryBuilder> build)
        {
            var query = new Query<ICustomerAccountPage>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerAccountPage>(query);
            return this;
        }

        public QueryRootCustomerAccountPagesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}