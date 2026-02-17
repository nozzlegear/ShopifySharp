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
    public sealed class CustomerMomentConnectionQueryBuilder : FieldsQueryBuilderBase<CustomerMomentConnection, CustomerMomentConnectionQueryBuilder>
    {
        protected override CustomerMomentConnectionQueryBuilder Self => this;

        public CustomerMomentConnectionQueryBuilder() : this("customerMomentConnection")
        {
        }

        public CustomerMomentConnectionQueryBuilder(string name) : base(new Query<CustomerMomentConnection>(name))
        {
        }

        public CustomerMomentConnectionQueryBuilder(IQuery<CustomerMomentConnection> query) : base(query)
        {
        }

        public CustomerMomentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerMomentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMomentEdge>(query);
            return this;
        }

        public CustomerMomentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentQueryBuilder> build)
        {
            var query = new Query<ICustomerMoment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerMoment>(query);
            return this;
        }

        public CustomerMomentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}