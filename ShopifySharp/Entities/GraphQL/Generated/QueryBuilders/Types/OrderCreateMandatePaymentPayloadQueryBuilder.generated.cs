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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class OrderCreateMandatePaymentPayloadQueryBuilder : FieldsQueryBuilderBase<OrderCreateMandatePaymentPayload, OrderCreateMandatePaymentPayloadQueryBuilder>
    {
        protected override OrderCreateMandatePaymentPayloadQueryBuilder Self => this;

        public OrderCreateMandatePaymentPayloadQueryBuilder() : this("orderCreateMandatePaymentPayload")
        {
        }

        public OrderCreateMandatePaymentPayloadQueryBuilder(string name) : base(new Query<OrderCreateMandatePaymentPayload>(name))
        {
        }

        public OrderCreateMandatePaymentPayloadQueryBuilder(IQuery<OrderCreateMandatePaymentPayload> query) : base(query)
        {
        }

        public OrderCreateMandatePaymentPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public OrderCreateMandatePaymentPayloadQueryBuilder PaymentReferenceId()
        {
            base.InnerQuery.AddField("paymentReferenceId");
            return this;
        }

        public OrderCreateMandatePaymentPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCreateMandatePaymentUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCreateMandatePaymentUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCreateMandatePaymentUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCreateMandatePaymentUserError>(query);
            return this;
        }
    }
}