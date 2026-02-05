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
    public sealed class BankAccountQueryBuilder : FieldsQueryBuilderBase<BankAccount, BankAccountQueryBuilder>
    {
        protected override BankAccountQueryBuilder Self => this;

        public BankAccountQueryBuilder() : this("bankAccount")
        {
        }

        public BankAccountQueryBuilder(string name) : base(new Query<BankAccount>(name))
        {
        }

        public BankAccountQueryBuilder(IQuery<BankAccount> query) : base(query)
        {
        }

        public BankAccountQueryBuilder AccountHolderType()
        {
            base.InnerQuery.AddField("accountHolderType");
            return this;
        }

        public BankAccountQueryBuilder AccountType()
        {
            base.InnerQuery.AddField("accountType");
            return this;
        }

        public BankAccountQueryBuilder BankName()
        {
            base.InnerQuery.AddField("bankName");
            return this;
        }

        public BankAccountQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentInstrumentBillingAddressQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentInstrumentBillingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentInstrumentBillingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentInstrumentBillingAddress>(query);
            return this;
        }

        public BankAccountQueryBuilder LastDigits()
        {
            base.InnerQuery.AddField("lastDigits");
            return this;
        }
    }
}