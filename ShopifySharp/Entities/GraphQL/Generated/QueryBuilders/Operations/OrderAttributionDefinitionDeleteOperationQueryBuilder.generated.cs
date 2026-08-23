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
    public sealed class OrderAttributionDefinitionDeleteOperationQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionDeletePayload, OrderAttributionDefinitionDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderAttributionDefinitionDeletePayload>, IHasArguments<OrderAttributionDefinitionDeleteArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderAttributionDefinitionDeleteArgumentsBuilder Arguments { get; }
        protected override OrderAttributionDefinitionDeleteOperationQueryBuilder Self => this;

        public OrderAttributionDefinitionDeleteOperationQueryBuilder() : this("orderAttributionDefinitionDelete")
        {
        }

        public OrderAttributionDefinitionDeleteOperationQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionDeletePayload>(name))
        {
            Arguments = new OrderAttributionDefinitionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionDeleteOperationQueryBuilder(IQuery<OrderAttributionDefinitionDeletePayload> query) : base(query)
        {
            Arguments = new OrderAttributionDefinitionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public OrderAttributionDefinitionDeleteOperationQueryBuilder SetArguments(Action<OrderAttributionDefinitionDeleteArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderAttributionDefinitionDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public OrderAttributionDefinitionDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderAttributionDefinitionDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAttributionDefinitionDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAttributionDefinitionDeleteUserError>(query);
            return this;
        }
    }
}