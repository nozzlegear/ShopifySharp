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
    public sealed class OrderEditBeginOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditBeginPayload, OrderEditBeginOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditBeginPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditBeginArgumentsBuilder Arguments { get; }
        protected override OrderEditBeginOperationQueryBuilder Self => this;

        public OrderEditBeginOperationQueryBuilder() : this("orderEditBegin")
        {
        }

        public OrderEditBeginOperationQueryBuilder(string name) : base(new Query<OrderEditBeginPayload>(name))
        {
            Arguments = new OrderEditBeginArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditBeginOperationQueryBuilder(IQuery<OrderEditBeginPayload> query) : base(query)
        {
            Arguments = new OrderEditBeginArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditBeginOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditBeginOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditBeginOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}