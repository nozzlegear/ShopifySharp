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
    public sealed class OrderStagedChangeConnectionQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeConnection, OrderStagedChangeConnectionQueryBuilder>
    {
        protected override OrderStagedChangeConnectionQueryBuilder Self => this;

        public OrderStagedChangeConnectionQueryBuilder() : this("orderStagedChangeConnection")
        {
        }

        public OrderStagedChangeConnectionQueryBuilder(string name) : base(new Query<OrderStagedChangeConnection>(name))
        {
        }

        public OrderStagedChangeConnectionQueryBuilder(IQuery<OrderStagedChangeConnection> query) : base(query)
        {
        }

        public OrderStagedChangeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeEdgeQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderStagedChangeEdge>(query);
            return this;
        }

        public OrderStagedChangeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public OrderStagedChangeConnectionQueryBuilder Nodes(Action<OrderStagedChangeUnionCasesBuilder> build)
        {
            var query = new Query<OrderStagedChange>("nodes");
            var unionBuilder = new OrderStagedChangeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}