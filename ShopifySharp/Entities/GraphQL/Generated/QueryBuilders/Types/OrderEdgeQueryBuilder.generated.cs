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
    public sealed class OrderEdgeQueryBuilder : FieldsQueryBuilderBase<OrderEdge, OrderEdgeQueryBuilder>
    {
        protected override OrderEdgeQueryBuilder Self => this;

        public OrderEdgeQueryBuilder() : this("orderEdge")
        {
        }

        public OrderEdgeQueryBuilder(string name) : base(new Query<OrderEdge>(name))
        {
        }

        public OrderEdgeQueryBuilder(IQuery<OrderEdge> query) : base(query)
        {
        }

        public OrderEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public OrderEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }
    }
}