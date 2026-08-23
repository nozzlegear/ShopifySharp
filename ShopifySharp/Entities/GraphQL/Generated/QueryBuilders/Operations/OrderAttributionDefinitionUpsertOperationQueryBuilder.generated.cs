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
    public sealed class OrderAttributionDefinitionUpsertOperationQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionUpsertPayload, OrderAttributionDefinitionUpsertOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderAttributionDefinitionUpsertPayload>, IHasArguments<OrderAttributionDefinitionUpsertArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderAttributionDefinitionUpsertArgumentsBuilder Arguments { get; }
        protected override OrderAttributionDefinitionUpsertOperationQueryBuilder Self => this;

        public OrderAttributionDefinitionUpsertOperationQueryBuilder() : this("orderAttributionDefinitionUpsert")
        {
        }

        public OrderAttributionDefinitionUpsertOperationQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionUpsertPayload>(name))
        {
            Arguments = new OrderAttributionDefinitionUpsertArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionUpsertOperationQueryBuilder(IQuery<OrderAttributionDefinitionUpsertPayload> query) : base(query)
        {
            Arguments = new OrderAttributionDefinitionUpsertArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionUpsertOperationQueryBuilder SetArguments(Action<OrderAttributionDefinitionUpsertArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderAttributionDefinitionUpsertOperationQueryBuilder OrderAttributionDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinition>("orderAttributionDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinition>(query);
            return this;
        }

        public OrderAttributionDefinitionUpsertOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionUpsertUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinitionUpsertUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionUpsertUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinitionUpsertUserError>(query);
            return this;
        }
    }
}