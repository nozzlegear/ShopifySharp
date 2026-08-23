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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class PaymentScheduleCaptureUserErrorQueryBuilder : FieldsQueryBuilderBase<PaymentScheduleCaptureUserError, PaymentScheduleCaptureUserErrorQueryBuilder>
    {
        protected override PaymentScheduleCaptureUserErrorQueryBuilder Self => this;

        public PaymentScheduleCaptureUserErrorQueryBuilder() : this("paymentScheduleCaptureUserError")
        {
        }

        public PaymentScheduleCaptureUserErrorQueryBuilder(string name) : base(new Query<PaymentScheduleCaptureUserError>(name))
        {
        }

        public PaymentScheduleCaptureUserErrorQueryBuilder(IQuery<PaymentScheduleCaptureUserError> query) : base(query)
        {
        }

        public PaymentScheduleCaptureUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PaymentScheduleCaptureUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PaymentScheduleCaptureUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}