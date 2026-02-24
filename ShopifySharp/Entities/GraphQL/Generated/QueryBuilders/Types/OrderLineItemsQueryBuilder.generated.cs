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
    public sealed class OrderLineItemsQueryBuilder : FieldsQueryBuilderBase<LineItemConnection, OrderLineItemsQueryBuilder>, IHasArguments<OrderLineItemsArgumentsBuilder>
    {
        public OrderLineItemsArgumentsBuilder Arguments { get; }
        protected override OrderLineItemsQueryBuilder Self => this;

        public OrderLineItemsQueryBuilder(string name) : base(new Query<LineItemConnection>(name))
        {
            Arguments = new OrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public OrderLineItemsQueryBuilder(IQuery<LineItemConnection> query) : base(query)
        {
            Arguments = new OrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public OrderLineItemsQueryBuilder SetArguments(Action<OrderLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder> build)
        {
            var query = new Query<LineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemEdge>(query);
            return this;
        }

        public OrderLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public OrderLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}