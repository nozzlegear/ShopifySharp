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
    public sealed class PaymentInstrumentUnionCasesBuilder : UnionCasesBuilderBase<PaymentInstrument, PaymentInstrumentUnionCasesBuilder>
    {
        protected override PaymentInstrumentUnionCasesBuilder Self => this;

        public PaymentInstrumentUnionCasesBuilder(string fieldName = "paymentInstrument") : this(new Query<PaymentInstrument>(fieldName))
        {
        }

        public PaymentInstrumentUnionCasesBuilder(IQuery<PaymentInstrument> query) : base(query)
        {
        }

        public PaymentInstrumentUnionCasesBuilder OnBankAccount(Action<BankAccountQueryBuilder> build)
        {
            var query = new Query<BankAccount>("... on BankAccount");
            var queryBuilder = new BankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentInstrumentUnionCasesBuilder OnVaultCreditCard(Action<VaultCreditCardQueryBuilder> build)
        {
            var query = new Query<VaultCreditCard>("... on VaultCreditCard");
            var queryBuilder = new VaultCreditCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentInstrumentUnionCasesBuilder OnVaultPaypalBillingAgreement(Action<VaultPaypalBillingAgreementQueryBuilder> build)
        {
            var query = new Query<VaultPaypalBillingAgreement>("... on VaultPaypalBillingAgreement");
            var queryBuilder = new VaultPaypalBillingAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}