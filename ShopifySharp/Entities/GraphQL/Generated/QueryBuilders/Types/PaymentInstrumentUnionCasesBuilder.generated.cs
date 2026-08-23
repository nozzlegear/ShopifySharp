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
    public sealed class PaymentInstrumentUnionCasesBuilder : UnionCasesBuilderBase<PaymentInstrument, PaymentInstrumentUnionCasesBuilder>
    {
        protected override PaymentInstrumentUnionCasesBuilder Self => this;

        public PaymentInstrumentUnionCasesBuilder(string fieldName = "paymentInstrument") : this(new Query<PaymentInstrument>(fieldName))
        {
        }

        public PaymentInstrumentUnionCasesBuilder(IQuery<PaymentInstrument> query) : base(query)
        {
        }

        public PaymentInstrumentUnionCasesBuilder OnBankAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BankAccountQueryBuilder> build)
        {
            var query = new Query<BankAccount>("... on BankAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentInstrumentUnionCasesBuilder OnVaultCreditCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.VaultCreditCardQueryBuilder> build)
        {
            var query = new Query<VaultCreditCard>("... on VaultCreditCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.VaultCreditCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PaymentInstrumentUnionCasesBuilder OnVaultPaypalBillingAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.VaultPaypalBillingAgreementQueryBuilder> build)
        {
            var query = new Query<VaultPaypalBillingAgreement>("... on VaultPaypalBillingAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.VaultPaypalBillingAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}