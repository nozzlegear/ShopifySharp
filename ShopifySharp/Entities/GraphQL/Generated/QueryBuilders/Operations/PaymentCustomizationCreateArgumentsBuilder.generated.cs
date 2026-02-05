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