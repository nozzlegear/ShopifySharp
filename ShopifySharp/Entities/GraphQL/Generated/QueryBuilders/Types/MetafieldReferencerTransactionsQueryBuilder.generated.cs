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
    public sealed class MetafieldReferencerTransactionsQueryBuilder : FieldsQueryBuilderBase<OrderTransaction, MetafieldReferencerTransactionsQueryBuilder>, IHasArguments<MetafieldReferencerTransactionsArgumentsBuilder>
    {
        public MetafieldReferencerTransactionsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerTransactionsQueryBuilder Self => this;

        public MetafieldReferencerTransactionsQueryBuilder(string name) : base(new Query<OrderTransaction>(name))
        {
            Arguments = new MetafieldReferencerTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerTransactionsQueryBuilder(IQuery<OrderTransaction> query) : base(query)
        {
            Arguments = new MetafieldReferencerTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerTransactionsQueryBuilder SetArguments(Action<MetafieldReferencerTransactionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder AccountNumber()
        {
            base.InnerQuery.AddField("accountNumber");
            return this;
        }

        [Obsolete("Use `amountSet` instead.")]
        public MetafieldReferencerTransactionsQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder AmountRoundingSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountRoundingSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder AmountV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amountV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        [Obsolete("Use `paymentId` instead.")]
        public MetafieldReferencerTransactionsQueryBuilder AuthorizationCode()
        {
            base.InnerQuery.AddField("authorizationCode");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder AuthorizationExpiresAt()
        {
            base.InnerQuery.AddField("authorizationExpiresAt");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder CurrencyExchangeAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencyExchangeAdjustmentQueryBuilder> build)
        {
            var query = new Query<CurrencyExchangeAdjustment>("currencyExchangeAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencyExchangeAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencyExchangeAdjustment>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Device(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("device");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Fees(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TransactionFeeQueryBuilder> build)
        {
            var query = new Query<TransactionFee>("fees");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TransactionFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TransactionFee>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder FormattedGateway()
        {
            base.InnerQuery.AddField("formattedGateway");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Gateway()
        {
            base.InnerQuery.AddField("gateway");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Kind()
        {
            base.InnerQuery.AddField("kind");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder ManuallyCapturable()
        {
            base.InnerQuery.AddField("manuallyCapturable");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder ManualPaymentGateway()
        {
            base.InnerQuery.AddField("manualPaymentGateway");
            return this;
        }

        [Obsolete("Use `maximumRefundableV2` instead.")]
        public MetafieldReferencerTransactionsQueryBuilder MaximumRefundable()
        {
            base.InnerQuery.AddField("maximumRefundable");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder MaximumRefundableV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maximumRefundableV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder MultiCapturable()
        {
            base.InnerQuery.AddField("multiCapturable");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder ParentTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("parentTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder PaymentIcon(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("paymentIcon");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder PaymentId()
        {
            base.InnerQuery.AddField("paymentId");
            return this;
        }

        [Obsolete("Use `paymentIcon` instead.")]
        public MetafieldReferencerTransactionsQueryBuilder PaymentMethod()
        {
            base.InnerQuery.AddField("paymentMethod");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder ReceiptJson()
        {
            base.InnerQuery.AddField("receiptJson");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder SettlementCurrency()
        {
            base.InnerQuery.AddField("settlementCurrency");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder SettlementCurrencyRate()
        {
            base.InnerQuery.AddField("settlementCurrencyRate");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder ShopifyPaymentsSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsTransactionSetQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsTransactionSet>("shopifyPaymentsSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsTransactionSetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsTransactionSet>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        [Obsolete("Use `totalUnsettledSet` instead.")]
        public MetafieldReferencerTransactionsQueryBuilder TotalUnsettled()
        {
            base.InnerQuery.AddField("totalUnsettled");
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder TotalUnsettledSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalUnsettledSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder TotalUnsettledV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalUnsettledV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder User(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("user");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetafieldReferencerTransactionsQueryBuilder PaymentDetails(Action<PaymentDetailsUnionCasesBuilder> build)
        {
            var query = new Query<PaymentDetails>("paymentDetails");
            var unionBuilder = new PaymentDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}