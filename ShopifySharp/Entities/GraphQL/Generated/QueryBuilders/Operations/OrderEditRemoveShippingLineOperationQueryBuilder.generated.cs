#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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

        public OrderEditRemoveShippingLineOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditRemoveShippingLineOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditRemoveShippingLineOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditRemoveShippingLineUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditRemoveShippingLineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditRemoveShippingLineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditRemoveShippingLineUserError>(query);
            return this;
        }
    }
}