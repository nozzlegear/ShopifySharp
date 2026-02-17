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
    public sealed class PaymentTermsTemplatesArgumentsBuilder : ArgumentsBuilderBase<PaymentTermsTemplate, PaymentTermsTemplatesArgumentsBuilder>
    {
        protected override PaymentTermsTemplatesArgumentsBuilder Self => this;

        public PaymentTermsTemplatesArgumentsBuilder(IQuery<PaymentTermsTemplate> query) : base(query)
        {
        }

        public PaymentTermsTemplatesArgumentsBuilder PaymentTermsType(PaymentTermsType? paymentTermsType)
        {
            base.InnerQuery.AddArgument("paymentTermsType", paymentTermsType);
            return this;
        }
    }
}