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
    public sealed class OrderAdjustmentEdgeQueryBuilder : FieldsQueryBuilderBase<OrderAdjustmentEdge, OrderAdjustmentEdgeQueryBuilder>
    {
        protected override OrderAdjustmentEdgeQueryBuilder Self => this;

        public OrderAdjustmentEdgeQueryBuilder() : this("orderAdjustmentEdge")
        {
        }

        public OrderAdjustmentEdgeQueryBuilder(string name) : base(new Query<OrderAdjustmentEdge>(name))
        {
        }

        public OrderAdjustmentEdgeQueryBuilder(IQuery<OrderAdjustmentEdge> query) : base(query)
        {
        }

        public OrderAdjustmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public OrderAdjustmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentQueryBuilder> build)
        {
            var query = new Query<OrderAdjustment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustment>(query);
            return this;
        }
    }
}