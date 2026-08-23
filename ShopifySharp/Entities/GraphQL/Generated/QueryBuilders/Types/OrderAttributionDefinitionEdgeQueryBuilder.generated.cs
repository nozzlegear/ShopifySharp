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
    public sealed class OrderAttributionDefinitionEdgeQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionEdge, OrderAttributionDefinitionEdgeQueryBuilder>
    {
        protected override OrderAttributionDefinitionEdgeQueryBuilder Self => this;

        public OrderAttributionDefinitionEdgeQueryBuilder() : this("orderAttributionDefinitionEdge")
        {
        }

        public OrderAttributionDefinitionEdgeQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionEdge>(name))
        {
        }

        public OrderAttributionDefinitionEdgeQueryBuilder(IQuery<OrderAttributionDefinitionEdge> query) : base(query)
        {
        }

        public OrderAttributionDefinitionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public OrderAttributionDefinitionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinition>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinition>(query);
            return this;
        }
    }
}