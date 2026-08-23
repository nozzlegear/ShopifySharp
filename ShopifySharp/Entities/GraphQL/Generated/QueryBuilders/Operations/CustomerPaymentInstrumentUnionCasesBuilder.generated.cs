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
    public sealed class CustomerPaymentInstrumentUnionCasesBuilder : UnionCasesBuilderBase<CustomerPaymentInstrument, CustomerPaymentInstrumentUnionCasesBuilder>
    {
        protected override CustomerPaymentInstrumentUnionCasesBuilder Self => this;

        public CustomerPaymentInstrumentUnionCasesBuilder(string fieldName = "instrument") : this(new Query<CustomerPaymentInstrument>(fieldName))
        {
        }

        public CustomerPaymentInstrumentUnionCasesBuilder(IQuery<CustomerPaymentInstrument> query) : base(query)
        {
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnBankAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BankAccountQueryBuilder> build)
        {
            var query = new Query<BankAccount>("... on BankAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnCustomerCreditCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerCreditCardQueryBuilder> build)
        {
            var query = new Query<CustomerCreditCard>("... on CustomerCreditCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerCreditCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnCustomerPaypalBillingAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaypalBillingAgreementQueryBuilder> build)
        {
            var query = new Query<CustomerPaypalBillingAgreement>("... on CustomerPaypalBillingAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaypalBillingAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnCustomerShopPayAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerShopPayAgreementQueryBuilder> build)
        {
            var query = new Query<CustomerShopPayAgreement>("... on CustomerShopPayAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerShopPayAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}