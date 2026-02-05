#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CustomerAccountPageEdgeQueryBuilder : FieldsQueryBuilderBase<CustomerAccountPageEdge, CustomerAccountPageEdgeQueryBuilder>
    {
        protected override CustomerAccountPageEdgeQueryBuilder Self => this;

        public CustomerAccountPageEdgeQueryBuilder() : this("customerAccountPageEdge")
        {
        }

        public CustomerAccountPageEdgeQueryBuilder(string name) : base(new Query<CustomerAccountPageEdge>(name))
        {
        }

        public CustomerAccountPageEdgeQueryBuilder(IQuery<CustomerAccountPageEdge> query) : base(query)
        {
        }

        public CustomerAccountPageEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CustomerAccountPageEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountPageQueryBuilder> build)
        {
            var query = new Query<ICustomerAccountPage>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerAccountPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerAccountPage>(query);
            return this;
        }
    }
}