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
    public sealed class PaymentCustomizationUpdateArgumentsBuilder : ArgumentsBuilderBase<PaymentCustomizationUpdatePayload, PaymentCustomizationUpdateArgumentsBuilder>
    {
        protected override PaymentCustomizationUpdateArgumentsBuilder Self => this;

        public PaymentCustomizationUpdateArgumentsBuilder(IQuery<PaymentCustomizationUpdatePayload> query) : base(query)
        {
        }

        public PaymentCustomizationUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public PaymentCustomizationUpdateArgumentsBuilder PaymentCustomization(PaymentCustomizationInput? paymentCustomization)
        {
            base.InnerQuery.AddArgument("paymentCustomization", paymentCustomization);
            return this;
        }
    }
}