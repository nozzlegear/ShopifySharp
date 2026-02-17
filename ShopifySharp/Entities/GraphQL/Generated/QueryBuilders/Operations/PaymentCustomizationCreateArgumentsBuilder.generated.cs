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
    public sealed class PaymentCustomizationCreateArgumentsBuilder : ArgumentsBuilderBase<PaymentCustomizationCreatePayload, PaymentCustomizationCreateArgumentsBuilder>
    {
        protected override PaymentCustomizationCreateArgumentsBuilder Self => this;

        public PaymentCustomizationCreateArgumentsBuilder(IQuery<PaymentCustomizationCreatePayload> query) : base(query)
        {
        }

        public PaymentCustomizationCreateArgumentsBuilder PaymentCustomization(PaymentCustomizationInput? paymentCustomization)
        {
            base.InnerQuery.AddArgument("paymentCustomization", paymentCustomization);
            return this;
        }
    }
}