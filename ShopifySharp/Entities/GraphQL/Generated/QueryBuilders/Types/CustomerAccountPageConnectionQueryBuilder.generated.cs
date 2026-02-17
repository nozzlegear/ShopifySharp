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
    public sealed class CustomerAccountPageConnectionQueryBuilder : FieldsQueryBuilderBase<CustomerAccountPageConnection, CustomerAccountPageConnectionQueryBuilder>
    {
        protected override CustomerAccountPageConnectionQueryBuilder Self => this;

        public CustomerAccountPageConnectionQueryBuilder() : this("customerAccountPageConnection")
        {
        }

        public CustomerAccountPageConnectionQueryBuilder(string name) : base(new Query<CustomerAccountPageConnection>(name))
        {
        }

        public CustomerAccountPageConnectionQueryBuilder(IQuery<CustomerAccountPageConnection> query) : base(query)
        {
        }

        public CustomerAccountPageConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerAccountPageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerAccountPageEdge>(query);
            return this;
        }

        public CustomerAccountPageConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageQueryBuilder> build)
        {
            var query = new Query<ICustomerAccountPage>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerAccountPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerAccountPage>(query);
            return this;
        }

        public CustomerAccountPageConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}