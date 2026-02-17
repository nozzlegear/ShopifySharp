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
    public sealed class OrderCreateManualPaymentOperationQueryBuilder : FieldsQueryBuilderBase<OrderCreateManualPaymentPayload, OrderCreateManualPaymentOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderCreateManualPaymentPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCreateManualPaymentArgumentsBuilder Arguments { get; }
        protected override OrderCreateManualPaymentOperationQueryBuilder Self => this;

        public OrderCreateManualPaymentOperationQueryBuilder() : this("orderCreateManualPayment")
        {
        }

        public OrderCreateManualPaymentOperationQueryBuilder(string name) : base(new Query<OrderCreateManualPaymentPayload>(name))
        {
            Arguments = new OrderCreateManualPaymentArgumentsBuilder(base.InnerQuery);
        }

        public OrderCreateManualPaymentOperationQueryBuilder(IQuery<OrderCreateManualPaymentPayload> query) : base(query)
        {
            Arguments = new OrderCreateManualPaymentArgumentsBuilder(base.InnerQuery);
        }

        public OrderCreateManualPaymentOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCreateManualPaymentOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder> build)
        {
            var query = new Query<OrderCreateManualPaymentOrderCreateManualPaymentError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateManualPaymentOrderCreateManualPaymentErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCreateManualPaymentOrderCreateManualPaymentError>(query);
            return this;
        }
    }
}