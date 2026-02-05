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
    public sealed class OrderAdjustmentConnectionQueryBuilder : FieldsQueryBuilderBase<OrderAdjustmentConnection, OrderAdjustmentConnectionQueryBuilder>
    {
        protected override OrderAdjustmentConnectionQueryBuilder Self => this;

        public OrderAdjustmentConnectionQueryBuilder() : this("orderAdjustmentConnection")
        {
        }

        public OrderAdjustmentConnectionQueryBuilder(string name) : base(new Query<OrderAdjustmentConnection>(name))
        {
        }

        public OrderAdjustmentConnectionQueryBuilder(IQuery<OrderAdjustmentConnection> query) : base(query)
        {
        }

        public OrderAdjustmentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentEdgeQueryBuilder> build)
        {
            var query = new Query<OrderAdjustmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustmentEdge>(query);
            return this;
        }

        public OrderAdjustmentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentQueryBuilder> build)
        {
            var query = new Query<OrderAdjustment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustment>(query);
            return this;
        }

        public OrderAdjustmentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}