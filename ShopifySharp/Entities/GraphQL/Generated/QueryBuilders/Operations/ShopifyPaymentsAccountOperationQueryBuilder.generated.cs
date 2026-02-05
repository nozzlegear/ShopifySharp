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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ShopifyPaymentsAccountOperationQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsAccount, ShopifyPaymentsAccountOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopifyPaymentsAccount>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override ShopifyPaymentsAccountOperationQueryBuilder Self => this;

        public ShopifyPaymentsAccountOperationQueryBuilder() : this("shopifyPaymentsAccount")
        {
        }

        public ShopifyPaymentsAccountOperationQueryBuilder(string name) : base(new Query<ShopifyPaymentsAccount>(name))
        {
        }

        public ShopifyPaymentsAccountOperationQueryBuilder(IQuery<ShopifyPaymentsAccount> query) : base(query)
        {
        }

        public ShopifyPaymentsAccountOperationQueryBuilder AccountOpenerName()
        {
            base.InnerQuery.AddField("accountOpenerName");
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder Activated()
        {
            base.InnerQuery.AddField("activated");
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder Balance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder BalanceTransactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransactionConnection>("balanceTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBalanceTransactionConnection>(query);
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder BankAccounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBankAccountConnectionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBankAccountConnection>("bankAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBankAccountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBankAccountConnection>(query);
            return this;
        }

        [Obsolete("Use `chargeStatementDescriptors` instead.")]
        public ShopifyPaymentsAccountOperationQueryBuilder ChargeStatementDescriptor()
        {
            base.InnerQuery.AddField("chargeStatementDescriptor");
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder ChargeStatementDescriptors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsChargeStatementDescriptorQueryBuilder> build)
        {
            var query = new Query<IShopifyPaymentsChargeStatementDescriptor>("chargeStatementDescriptors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsChargeStatementDescriptorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IShopifyPaymentsChargeStatementDescriptor>(query);
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder DefaultCurrency()
        {
            base.InnerQuery.AddField("defaultCurrency");
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder Disputes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeConnectionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeConnection>("disputes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsDisputeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeConnection>(query);
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder Onboardable()
        {
            base.InnerQuery.AddField("onboardable");
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder Payouts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutConnectionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutConnection>("payouts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutConnection>(query);
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder PayoutSchedule(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutScheduleQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutSchedule>("payoutSchedule");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutScheduleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutSchedule>(query);
            return this;
        }

        public ShopifyPaymentsAccountOperationQueryBuilder PayoutStatementDescriptor()
        {
            base.InnerQuery.AddField("payoutStatementDescriptor");
            return this;
        }
    }
}