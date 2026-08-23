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
    public sealed class PaymentScheduleCaptureOperationQueryBuilder : FieldsQueryBuilderBase<PaymentScheduleCapturePayload, PaymentScheduleCaptureOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentScheduleCapturePayload>, IHasArguments<PaymentScheduleCaptureArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PaymentScheduleCaptureArgumentsBuilder Arguments { get; }
        protected override PaymentScheduleCaptureOperationQueryBuilder Self => this;

        public PaymentScheduleCaptureOperationQueryBuilder() : this("paymentScheduleCapture")
        {
        }

        public PaymentScheduleCaptureOperationQueryBuilder(string name) : base(new Query<PaymentScheduleCapturePayload>(name))
        {
            Arguments = new PaymentScheduleCaptureArgumentsBuilder(base.InnerQuery);
        }

        public PaymentScheduleCaptureOperationQueryBuilder(IQuery<PaymentScheduleCapturePayload> query) : base(query)
        {
            Arguments = new PaymentScheduleCaptureArgumentsBuilder(base.InnerQuery);
        }

        public PaymentScheduleCaptureOperationQueryBuilder SetArguments(Action<PaymentScheduleCaptureArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PaymentScheduleCaptureOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public PaymentScheduleCaptureOperationQueryBuilder JobResult(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateMandatePaymentJobResultQueryBuilder> build)
        {
            var query = new Query<OrderCreateMandatePaymentJobResult>("jobResult");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderCreateMandatePaymentJobResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCreateMandatePaymentJobResult>(query);
            return this;
        }

        public PaymentScheduleCaptureOperationQueryBuilder PaymentReferenceId()
        {
            base.InnerQuery.AddField("paymentReferenceId");
            return this;
        }

        public PaymentScheduleCaptureOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleCaptureUserErrorQueryBuilder> build)
        {
            var query = new Query<PaymentScheduleCaptureUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleCaptureUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentScheduleCaptureUserError>(query);
            return this;
        }
    }
}