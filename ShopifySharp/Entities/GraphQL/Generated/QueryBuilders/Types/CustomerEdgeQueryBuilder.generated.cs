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

        public CustomerEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }
    }
}