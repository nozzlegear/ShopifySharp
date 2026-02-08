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
    public sealed class CustomerEdgeQueryBuilder : FieldsQueryBuilderBase<CustomerEdge, CustomerEdgeQueryBuilder>
    {
        protected override CustomerEdgeQueryBuilder Self => this;

        public CustomerEdgeQueryBuilder() : this("customerEdge")
        {
        }

        public CustomerEdgeQueryBuilder(string name) : base(new Query<CustomerEdge>(name))
        {
        }

        public CustomerEdgeQueryBuilder(IQuery<CustomerEdge> query) : base(query)
        {
        }

        public CustomerEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CustomerEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }
    }
}