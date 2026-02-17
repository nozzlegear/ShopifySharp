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
    public sealed class CustomerMomentEdgeQueryBuilder : FieldsQueryBuilderBase<CustomerMomentEdge, CustomerMomentEdgeQueryBuilder>
    {
        protected override CustomerMomentEdgeQueryBuilder Self => this;

        public CustomerMomentEdgeQueryBuilder() : this("customerMomentEdge")
        {
        }

        public CustomerMomentEdgeQueryBuilder(string name) : base(new Query<CustomerMomentEdge>(name))
        {
        }

        public CustomerMomentEdgeQueryBuilder(IQuery<CustomerMomentEdge> query) : base(query)
        {
        }

        public CustomerMomentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CustomerMomentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentQueryBuilder> build)
        {
            var query = new Query<ICustomerMoment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerMoment>(query);
            return this;
        }
    }
}