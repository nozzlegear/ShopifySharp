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
    public sealed class OrderEditUpdateShippingLineOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditUpdateShippingLinePayload, OrderEditUpdateShippingLineOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditUpdateShippingLinePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditUpdateShippingLineArgumentsBuilder Arguments { get; }
        protected override OrderEditUpdateShippingLineOperationQueryBuilder Self => this;

        public OrderEditUpdateShippingLineOperationQueryBuilder() : this("orderEditUpdateShippingLine")
        {
        }

        public OrderEditUpdateShippingLineOperationQueryBuilder(string name) : base(new Query<OrderEditUpdateShippingLinePayload>(name))
        {
            Arguments = new OrderEditUpdateShippingLineArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditUpdateShippingLineOperationQueryBuilder(IQuery<OrderEditUpdateShippingLinePayload> query) : base(query)
        {
            Arguments = new OrderEditUpdateShippingLineArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditUpdateShippingLineOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditUpdateShippingLineOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditUpdateShippingLineOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditUpdateShippingLineUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditUpdateShippingLineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditUpdateShippingLineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditUpdateShippingLineUserError>(query);
            return this;
        }
    }
}