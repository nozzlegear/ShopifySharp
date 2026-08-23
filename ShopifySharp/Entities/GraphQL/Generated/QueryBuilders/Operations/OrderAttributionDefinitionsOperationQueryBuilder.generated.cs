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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class OrderAttributionDefinitionsOperationQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionConnection, OrderAttributionDefinitionsOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderAttributionDefinitionConnection>, IHasArguments<OrderAttributionDefinitionsArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public OrderAttributionDefinitionsArgumentsBuilder Arguments { get; }
        protected override OrderAttributionDefinitionsOperationQueryBuilder Self => this;

        public OrderAttributionDefinitionsOperationQueryBuilder() : this("orderAttributionDefinitions")
        {
        }

        public OrderAttributionDefinitionsOperationQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionConnection>(name))
        {
            Arguments = new OrderAttributionDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionsOperationQueryBuilder(IQuery<OrderAttributionDefinitionConnection> query) : base(query)
        {
            Arguments = new OrderAttributionDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionsOperationQueryBuilder SetArguments(Action<OrderAttributionDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderAttributionDefinitionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinitionEdge>(query);
            return this;
        }

        public OrderAttributionDefinitionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinition>(query);
            return this;
        }

        public OrderAttributionDefinitionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}