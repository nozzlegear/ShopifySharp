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
    public sealed class ShopifyPaymentsPayoutQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayout, ShopifyPaymentsPayoutQueryBuilder>
    {
        protected override ShopifyPaymentsPayoutQueryBuilder Self => this;

        public ShopifyPaymentsPayoutQueryBuilder() : this("shopifyPaymentsPayout")
        {
        }

        public ShopifyPaymentsPayoutQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayout>(name))
        {
        }

        public ShopifyPaymentsPayoutQueryBuilder(IQuery<ShopifyPaymentsPayout> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutQueryBuilder BankAccount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBankAccount>("bankAccount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBankAccount>(query);
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder BusinessEntity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder> build)
        {
            var query = new Query<BusinessEntity>("businessEntity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntity>(query);
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder ExternalTraceId()
        {
            base.InnerQuery.AddField("externalTraceId");
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder Gross(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("gross");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder IssuedAt()
        {
            base.InnerQuery.AddField("issuedAt");
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder Net(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("net");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder Summary(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutSummaryQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutSummary>("summary");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutSummary>(query);
            return this;
        }

        public ShopifyPaymentsPayoutQueryBuilder TransactionType()
        {
            base.InnerQuery.AddField("transactionType");
            return this;
        }
    }
}