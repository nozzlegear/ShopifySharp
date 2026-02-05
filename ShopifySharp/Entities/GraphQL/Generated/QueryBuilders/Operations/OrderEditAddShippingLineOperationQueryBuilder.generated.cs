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
    public sealed class OrderEditAddShippingLineOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditAddShippingLinePayload, OrderEditAddShippingLineOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditAddShippingLinePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditAddShippingLineArgumentsBuilder Arguments { get; }
        protected override OrderEditAddShippingLineOperationQueryBuilder Self => this;

        public OrderEditAddShippingLineOperationQueryBuilder() : this("orderEditAddShippingLine")
        {
        }

        public OrderEditAddShippingLineOperationQueryBuilder(string name) : base(new Query<OrderEditAddShippingLinePayload>(name))
        {
            Arguments = new OrderEditAddShippingLineArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddShippingLineOperationQueryBuilder(IQuery<OrderEditAddShippingLinePayload> query) : base(query)
        {
            Arguments = new OrderEditAddShippingLineArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddShippingLineOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditAddShippingLineOperationQueryBuilder CalculatedShippingLine(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedShippingLineQueryBuilder> build)
        {
            var query = new Query<CalculatedShippingLine>("calculatedShippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedShippingLine>(query);
            return this;
        }

        public OrderEditAddShippingLineOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditAddShippingLineOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditAddShippingLineUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditAddShippingLineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditAddShippingLineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditAddShippingLineUserError>(query);
            return this;
        }
    }
}