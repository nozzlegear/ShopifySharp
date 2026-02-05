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

        public OrderAdjustmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentQueryBuilder> build)
        {
            var query = new Query<OrderAdjustment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustment>(query);
            return this;
        }
    }
}