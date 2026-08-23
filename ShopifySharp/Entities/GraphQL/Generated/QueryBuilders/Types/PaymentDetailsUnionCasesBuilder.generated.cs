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
    public sealed class PaymentDetailsUnionCasesBuilder : UnionCasesBuilderBase<PaymentDetails, PaymentDetailsUnionCasesBuilder>
    {
        protected override PaymentDetailsUnionCasesBuilder Self => this;

        public PaymentDetailsUnionCasesBuilder(string fieldName = "paymentDetails") : this(new Query<PaymentDetails>(fieldName))
        {
        }

        public PaymentDetailsUnionCasesBuilder(IQuery<PaymentDetails> query) : base(query)
        {
        }

        public PaymentDetailsUnionCasesBuilder OnCardPaymentDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CardPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<CardPaymentDetails>("... on CardPaymentDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CardPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentDetailsUnionCasesBuilder OnLocalPaymentMethodsPaymentDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalPaymentMethodsPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<LocalPaymentMethodsPaymentDetails>("... on LocalPaymentMethodsPaymentDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalPaymentMethodsPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentDetailsUnionCasesBuilder OnPaypalWalletPaymentDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaypalWalletPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<PaypalWalletPaymentDetails>("... on PaypalWalletPaymentDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaypalWalletPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentDetailsUnionCasesBuilder OnShopPayInstallmentsPaymentDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayInstallmentsPaymentDetailsQueryBuilder> build)
        {
            var query = new Query<ShopPayInstallmentsPaymentDetails>("... on ShopPayInstallmentsPaymentDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayInstallmentsPaymentDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}