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
    public sealed class OrderShippingLinesQueryBuilder : FieldsQueryBuilderBase<ShippingLineConnection, OrderShippingLinesQueryBuilder>, IHasArguments<OrderShippingLinesArgumentsBuilder>
    {
        public OrderShippingLinesArgumentsBuilder Arguments { get; }
        protected override OrderShippingLinesQueryBuilder Self => this;

        public OrderShippingLinesQueryBuilder(string name) : base(new Query<ShippingLineConnection>(name))
        {
            Arguments = new OrderShippingLinesArgumentsBuilder(base.InnerQuery);
        }

        public OrderShippingLinesQueryBuilder(IQuery<ShippingLineConnection> query) : base(query)
        {
            Arguments = new OrderShippingLinesArgumentsBuilder(base.InnerQuery);
        }

        public OrderShippingLinesQueryBuilder SetArguments(Action<OrderShippingLinesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderShippingLinesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineEdgeQueryBuilder> build)
        {
            var query = new Query<ShippingLineEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLineEdge>(query);
            return this;
        }

        public OrderShippingLinesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public OrderShippingLinesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}