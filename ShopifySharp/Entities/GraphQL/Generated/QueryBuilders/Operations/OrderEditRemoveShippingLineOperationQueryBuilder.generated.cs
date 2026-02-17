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
    public sealed class OrderEditRemoveShippingLineOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditRemoveShippingLinePayload, OrderEditRemoveShippingLineOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditRemoveShippingLinePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditRemoveShippingLineArgumentsBuilder Arguments { get; }
        protected override OrderEditRemoveShippingLineOperationQueryBuilder Self => this;

        public OrderEditRemoveShippingLineOperationQueryBuilder() : this("orderEditRemoveShippingLine")
        {
        }

        public OrderEditRemoveShippingLineOperationQueryBuilder(string name) : base(new Query<OrderEditRemoveShippingLinePayload>(name))
        {
            Arguments = new OrderEditRemoveShippingLineArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditRemoveShippingLineOperationQueryBuilder(IQuery<OrderEditRemoveShippingLinePayload> query) : base(query)
        {
            Arguments = new OrderEditRemoveShippingLineArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditRemoveShippingLineOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditRemoveShippingLineOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditRemoveShippingLineOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditRemoveShippingLineUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditRemoveShippingLineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditRemoveShippingLineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditRemoveShippingLineUserError>(query);
            return this;
        }
    }
}