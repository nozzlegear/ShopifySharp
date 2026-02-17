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
    public sealed class OrderCreateMandatePaymentOperationQueryBuilder : FieldsQueryBuilderBase<OrderCreateMandatePaymentPayload, OrderCreateMandatePaymentOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderCreateMandatePaymentPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderCreateMandatePaymentArgumentsBuilder Arguments { get; }
        protected override OrderCreateMandatePaymentOperationQueryBuilder Self => this;

        public OrderCreateMandatePaymentOperationQueryBuilder() : this("orderCreateMandatePayment")
        {
        }

        public OrderCreateMandatePaymentOperationQueryBuilder(string name) : base(new Query<OrderCreateMandatePaymentPayload>(name))
        {
            Arguments = new OrderCreateMandatePaymentArgumentsBuilder(base.InnerQuery);
        }

        public OrderCreateMandatePaymentOperationQueryBuilder(IQuery<OrderCreateMandatePaymentPayload> query) : base(query)
        {
            Arguments = new OrderCreateMandatePaymentArgumentsBuilder(base.InnerQuery);
        }

        public OrderCreateMandatePaymentOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public OrderCreateMandatePaymentOperationQueryBuilder PaymentReferenceId()
        {
            base.InnerQuery.AddField("paymentReferenceId");
            return this;
        }

        public OrderCreateMandatePaymentOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateMandatePaymentUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCreateMandatePaymentUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateMandatePaymentUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCreateMandatePaymentUserError>(query);
            return this;
        }
    }
}