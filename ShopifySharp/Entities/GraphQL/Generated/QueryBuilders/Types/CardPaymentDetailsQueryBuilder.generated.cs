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
    public sealed class CardPaymentDetailsQueryBuilder : FieldsQueryBuilderBase<CardPaymentDetails, CardPaymentDetailsQueryBuilder>
    {
        protected override CardPaymentDetailsQueryBuilder Self => this;

        public CardPaymentDetailsQueryBuilder() : this("cardPaymentDetails")
        {
        }

        public CardPaymentDetailsQueryBuilder(string name) : base(new Query<CardPaymentDetails>(name))
        {
        }

        public CardPaymentDetailsQueryBuilder(IQuery<CardPaymentDetails> query) : base(query)
        {
        }

        public CardPaymentDetailsQueryBuilder AvsResultCode()
        {
            base.InnerQuery.AddField("avsResultCode");
            return this;
        }

        public CardPaymentDetailsQueryBuilder Bin()
        {
            base.InnerQuery.AddField("bin");
            return this;
        }

        public CardPaymentDetailsQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public CardPaymentDetailsQueryBuilder CvvResultCode()
        {
            base.InnerQuery.AddField("cvvResultCode");
            return this;
        }

        public CardPaymentDetailsQueryBuilder ExpirationMonth()
        {
            base.InnerQuery.AddField("expirationMonth");
            return this;
        }

        public CardPaymentDetailsQueryBuilder ExpirationYear()
        {
            base.InnerQuery.AddField("expirationYear");
            return this;
        }

        public CardPaymentDetailsQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CardPaymentDetailsQueryBuilder Number()
        {
            base.InnerQuery.AddField("number");
            return this;
        }

        public CardPaymentDetailsQueryBuilder PaymentMethodName()
        {
            base.InnerQuery.AddField("paymentMethodName");
            return this;
        }

        public CardPaymentDetailsQueryBuilder Wallet()
        {
            base.InnerQuery.AddField("wallet");
            return this;
        }
    }
}