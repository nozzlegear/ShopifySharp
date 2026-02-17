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
    public sealed class ShopifyPaymentsBankAccountQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBankAccount, ShopifyPaymentsBankAccountQueryBuilder>
    {
        protected override ShopifyPaymentsBankAccountQueryBuilder Self => this;

        public ShopifyPaymentsBankAccountQueryBuilder() : this("shopifyPaymentsBankAccount")
        {
        }

        public ShopifyPaymentsBankAccountQueryBuilder(string name) : base(new Query<ShopifyPaymentsBankAccount>(name))
        {
        }

        public ShopifyPaymentsBankAccountQueryBuilder(IQuery<ShopifyPaymentsBankAccount> query) : base(query)
        {
        }

        public ShopifyPaymentsBankAccountQueryBuilder AccountNumberLastDigits()
        {
            base.InnerQuery.AddField("accountNumberLastDigits");
            return this;
        }

        public ShopifyPaymentsBankAccountQueryBuilder BankName()
        {
            base.InnerQuery.AddField("bankName");
            return this;
        }

        public ShopifyPaymentsBankAccountQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public ShopifyPaymentsBankAccountQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ShopifyPaymentsBankAccountQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public ShopifyPaymentsBankAccountQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsBankAccountQueryBuilder Payouts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutConnectionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutConnection>("payouts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutConnection>(query);
            return this;
        }

        public ShopifyPaymentsBankAccountQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}