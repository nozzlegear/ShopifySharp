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
    public sealed class CustomerPaymentInstrumentUnionCasesBuilder : UnionCasesBuilderBase<CustomerPaymentInstrument, CustomerPaymentInstrumentUnionCasesBuilder>
    {
        protected override CustomerPaymentInstrumentUnionCasesBuilder Self => this;

        public CustomerPaymentInstrumentUnionCasesBuilder(string fieldName = "instrument") : this(new Query<CustomerPaymentInstrument>(fieldName))
        {
        }

        public CustomerPaymentInstrumentUnionCasesBuilder(IQuery<CustomerPaymentInstrument> query) : base(query)
        {
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnBankAccount(Action<BankAccountQueryBuilder> build)
        {
            var query = new Query<BankAccount>("... on BankAccount");
            var queryBuilder = new BankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnCustomerCreditCard(Action<CustomerCreditCardQueryBuilder> build)
        {
            var query = new Query<CustomerCreditCard>("... on CustomerCreditCard");
            var queryBuilder = new CustomerCreditCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnCustomerPaypalBillingAgreement(Action<CustomerPaypalBillingAgreementQueryBuilder> build)
        {
            var query = new Query<CustomerPaypalBillingAgreement>("... on CustomerPaypalBillingAgreement");
            var queryBuilder = new CustomerPaypalBillingAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CustomerPaymentInstrumentUnionCasesBuilder OnCustomerShopPayAgreement(Action<CustomerShopPayAgreementQueryBuilder> build)
        {
            var query = new Query<CustomerShopPayAgreement>("... on CustomerShopPayAgreement");
            var queryBuilder = new CustomerShopPayAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}