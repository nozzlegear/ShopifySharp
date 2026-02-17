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
    public sealed class OrderEditSetQuantityOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditSetQuantityPayload, OrderEditSetQuantityOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditSetQuantityPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditSetQuantityArgumentsBuilder Arguments { get; }
        protected override OrderEditSetQuantityOperationQueryBuilder Self => this;

        public OrderEditSetQuantityOperationQueryBuilder() : this("orderEditSetQuantity")
        {
        }

        public OrderEditSetQuantityOperationQueryBuilder(string name) : base(new Query<OrderEditSetQuantityPayload>(name))
        {
            Arguments = new OrderEditSetQuantityArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditSetQuantityOperationQueryBuilder(IQuery<OrderEditSetQuantityPayload> query) : base(query)
        {
            Arguments = new OrderEditSetQuantityArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditSetQuantityOperationQueryBuilder CalculatedLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("calculatedLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public OrderEditSetQuantityOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditSetQuantityOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditSetQuantityOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}