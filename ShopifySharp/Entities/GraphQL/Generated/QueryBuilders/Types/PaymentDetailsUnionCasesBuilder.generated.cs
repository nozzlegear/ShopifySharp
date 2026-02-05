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
    public sealed class PaymentDetailsUnionCasesBuilder : UnionCasesBuilderBase<PaymentDetails, PaymentDetailsUnionCasesBuilder>
    {
        protected override PaymentDetailsUnionCasesBuilder Self => this;

        public PaymentDetailsUnionCasesBuilder(string fieldName = "paymentDetails") : this(new Query<PaymentDetails>(fieldName))
        {
        }

        public PaymentDetailsUnionCasesBuilder(IQuery<PaymentDetails> query) : base(query)
        {
        }

        public PaymentDetailsUnionCasesBuilder OnCardPaymentDetails(Action<CardPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<CardPaymentDetails>("... on CardPaymentDetails");
            var queryBuilder = new CardPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentDetailsUnionCasesBuilder OnLocalPaymentMethodsPaymentDetails(Action<LocalPaymentMethodsPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<LocalPaymentMethodsPaymentDetails>("... on LocalPaymentMethodsPaymentDetails");
            var queryBuilder = new LocalPaymentMethodsPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentDetailsUnionCasesBuilder OnPaypalWalletPaymentDetails(Action<PaypalWalletPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<PaypalWalletPaymentDetails>("... on PaypalWalletPaymentDetails");
            var queryBuilder = new PaypalWalletPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentDetailsUnionCasesBuilder OnShopPayInstallmentsPaymentDetails(Action<ShopPayInstallmentsPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<ShopPayInstallmentsPaymentDetails>("... on ShopPayInstallmentsPaymentDetails");
            var queryBuilder = new ShopPayInstallmentsPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}