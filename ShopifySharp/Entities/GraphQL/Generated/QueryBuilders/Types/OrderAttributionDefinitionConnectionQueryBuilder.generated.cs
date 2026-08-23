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
    public sealed class OrderAttributionDefinitionConnectionQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionConnection, OrderAttributionDefinitionConnectionQueryBuilder>, IHasArguments<OrderAttributionDefinitionConnectionArgumentsBuilder>
    {
        public OrderAttributionDefinitionConnectionArgumentsBuilder Arguments { get; }
        protected override OrderAttributionDefinitionConnectionQueryBuilder Self => this;

        public OrderAttributionDefinitionConnectionQueryBuilder() : this("orderAttributionDefinitionConnection")
        {
        }

        public OrderAttributionDefinitionConnectionQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionConnection>(name))
        {
            Arguments = new OrderAttributionDefinitionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionConnectionQueryBuilder(IQuery<OrderAttributionDefinitionConnection> query) : base(query)
        {
            Arguments = new OrderAttributionDefinitionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionConnectionQueryBuilder SetArguments(Action<OrderAttributionDefinitionConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderAttributionDefinitionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinitionEdge>(query);
            return this;
        }

        public OrderAttributionDefinitionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinition>(query);
            return this;
        }

        public OrderAttributionDefinitionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}