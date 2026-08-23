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
    public sealed class PaymentScheduleCaptureArgumentsBuilder : ArgumentsBuilderBase<PaymentScheduleCapturePayload, PaymentScheduleCaptureArgumentsBuilder>
    {
        protected override PaymentScheduleCaptureArgumentsBuilder Self => this;

        public PaymentScheduleCaptureArgumentsBuilder(IQuery<PaymentScheduleCapturePayload> query) : base(query)
        {
        }

        public PaymentScheduleCaptureArgumentsBuilder PaymentScheduleId(string? paymentScheduleId)
        {
            base.InnerQuery.AddArgument("paymentScheduleId", paymentScheduleId);
            return this;
        }
    }
}