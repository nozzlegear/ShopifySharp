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
    public sealed class PaymentTermsCreateArgumentsBuilder : ArgumentsBuilderBase<PaymentTermsCreatePayload, PaymentTermsCreateArgumentsBuilder>
    {
        protected override PaymentTermsCreateArgumentsBuilder Self => this;

        public PaymentTermsCreateArgumentsBuilder(IQuery<PaymentTermsCreatePayload> query) : base(query)
        {
        }

        public PaymentTermsCreateArgumentsBuilder PaymentTermsAttributes(PaymentTermsCreateInput? paymentTermsAttributes)
        {
            base.InnerQuery.AddArgument("paymentTermsAttributes", paymentTermsAttributes);
            return this;
        }

        public PaymentTermsCreateArgumentsBuilder ReferenceId(string? referenceId)
        {
            base.InnerQuery.AddArgument("referenceId", referenceId);
            return this;
        }
    }
}