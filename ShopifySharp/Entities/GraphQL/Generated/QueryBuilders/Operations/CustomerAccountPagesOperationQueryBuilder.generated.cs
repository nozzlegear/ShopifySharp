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
    public sealed class CustomerAccountPagesOperationQueryBuilder : FieldsQueryBuilderBase<CustomerAccountPageConnection, CustomerAccountPagesOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerAccountPageConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomerAccountPagesArgumentsBuilder Arguments { get; }
        protected override CustomerAccountPagesOperationQueryBuilder Self => this;

        public CustomerAccountPagesOperationQueryBuilder() : this("customerAccountPages")
        {
        }

        public CustomerAccountPagesOperationQueryBuilder(string name) : base(new Query<CustomerAccountPageConnection>(name))
        {
            Arguments = new CustomerAccountPagesArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAccountPagesOperationQueryBuilder(IQuery<CustomerAccountPageConnection> query) : base(query)
        {
            Arguments = new CustomerAccountPagesArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAccountPagesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerAccountPageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerAccountPageEdge>(query);
            return this;
        }

        public CustomerAccountPagesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageQueryBuilder> build)
        {
            var query = new Query<ICustomerAccountPage>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerAccountPage>(query);
            return this;
        }

        public CustomerAccountPagesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}