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
    public sealed class PaypalWalletPaymentDetailsQueryBuilder : FieldsQueryBuilderBase<PaypalWalletPaymentDetails, PaypalWalletPaymentDetailsQueryBuilder>
    {
        protected override PaypalWalletPaymentDetailsQueryBuilder Self => this;

        public PaypalWalletPaymentDetailsQueryBuilder() : this("paypalWalletPaymentDetails")
        {
        }

        public PaypalWalletPaymentDetailsQueryBuilder(string name) : base(new Query<PaypalWalletPaymentDetails>(name))
        {
        }

        public PaypalWalletPaymentDetailsQueryBuilder(IQuery<PaypalWalletPaymentDetails> query) : base(query)
        {
        }

        public PaypalWalletPaymentDetailsQueryBuilder PaymentMethodName()
        {
            base.InnerQuery.AddField("paymentMethodName");
            return this;
        }
    }
}