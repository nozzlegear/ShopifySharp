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
    public sealed class OrderTransactionEdgeQueryBuilder : FieldsQueryBuilderBase<OrderTransactionEdge, OrderTransactionEdgeQueryBuilder>
    {
        protected override OrderTransactionEdgeQueryBuilder Self => this;

        public OrderTransactionEdgeQueryBuilder() : this("orderTransactionEdge")
        {
        }

        public OrderTransactionEdgeQueryBuilder(string name) : base(new Query<OrderTransactionEdge>(name))
        {
        }

        public OrderTransactionEdgeQueryBuilder(IQuery<OrderTransactionEdge> query) : base(query)
        {
        }

        public OrderTransactionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public OrderTransactionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }
    }
}