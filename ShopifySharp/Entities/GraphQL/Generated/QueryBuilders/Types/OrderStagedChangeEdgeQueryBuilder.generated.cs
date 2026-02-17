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
    public sealed class OrderStagedChangeEdgeQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeEdge, OrderStagedChangeEdgeQueryBuilder>
    {
        protected override OrderStagedChangeEdgeQueryBuilder Self => this;

        public OrderStagedChangeEdgeQueryBuilder() : this("orderStagedChangeEdge")
        {
        }

        public OrderStagedChangeEdgeQueryBuilder(string name) : base(new Query<OrderStagedChangeEdge>(name))
        {
        }

        public OrderStagedChangeEdgeQueryBuilder(IQuery<OrderStagedChangeEdge> query) : base(query)
        {
        }

        public OrderStagedChangeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public OrderStagedChangeEdgeQueryBuilder Node(Action<OrderStagedChangeUnionCasesBuilder> build)
        {
            var query = new Query<OrderStagedChange>("node");
            var unionBuilder = new OrderStagedChangeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}