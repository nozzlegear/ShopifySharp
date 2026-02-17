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
    public sealed class OrderEditUpdateDiscountOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditUpdateDiscountPayload, OrderEditUpdateDiscountOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditUpdateDiscountPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditUpdateDiscountArgumentsBuilder Arguments { get; }
        protected override OrderEditUpdateDiscountOperationQueryBuilder Self => this;

        public OrderEditUpdateDiscountOperationQueryBuilder() : this("orderEditUpdateDiscount")
        {
        }

        public OrderEditUpdateDiscountOperationQueryBuilder(string name) : base(new Query<OrderEditUpdateDiscountPayload>(name))
        {
            Arguments = new OrderEditUpdateDiscountArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditUpdateDiscountOperationQueryBuilder(IQuery<OrderEditUpdateDiscountPayload> query) : base(query)
        {
            Arguments = new OrderEditUpdateDiscountArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditUpdateDiscountOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditUpdateDiscountOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditUpdateDiscountOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditUpdateDiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditUpdateDiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditUpdateDiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditUpdateDiscountUserError>(query);
            return this;
        }
    }
}