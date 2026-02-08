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
    public sealed class OrderTransactionQueryBuilder : FieldsQueryBuilderBase<OrderTransaction, OrderTransactionQueryBuilder>
    {
        protected override OrderTransactionQueryBuilder Self => this;

        public OrderTransactionQueryBuilder() : this("orderTransaction")
        {
        }

        public OrderTransactionQueryBuilder(string name) : base(new Query<OrderTransaction>(name))
        {
        }

        public OrderTransactionQueryBuilder(IQuery<OrderTransaction> query) : base(query)
        {
        }

        public OrderTransactionQueryBuilder AccountNumber()
        {
            base.InnerQuery.AddField("accountNumber");
            return this;
        }

        [Obsolete("Use `amountSet` instead.")]
        public OrderTransactionQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public OrderTransactionQueryBuilder AmountRoundingSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountRoundingSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderTransactionQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderTransactionQueryBuilder AmountV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amountV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        [Obsolete("Use `paymentId` instead.")]
        public OrderTransactionQueryBuilder AuthorizationCode()
        {
            base.InnerQuery.AddField("authorizationCode");
            return this;
        }

        public OrderTransactionQueryBuilder AuthorizationExpiresAt()
        {
            base.InnerQuery.AddField("authorizationExpiresAt");
            return this;
        }

        public OrderTransactionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public OrderTransactionQueryBuilder CurrencyExchangeAdjustment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencyExchangeAdjustmentQueryBuilder> build)
        {
            var query = new Query<CurrencyExchangeAdjustment>("currencyExchangeAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencyExchangeAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencyExchangeAdjustment>(query);
            return this;
        }

        public OrderTransactionQueryBuilder Device(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("device");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public OrderTransactionQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public OrderTransactionQueryBuilder Fees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TransactionFeeQueryBuilder> build)
        {
            var query = new Query<TransactionFee>("fees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TransactionFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TransactionFee>(query);
            return this;
        }

        public OrderTransactionQueryBuilder FormattedGateway()
        {
            base.InnerQuery.AddField("formattedGateway");
            return this;
        }

        public OrderTransactionQueryBuilder Gateway()
        {
            base.InnerQuery.AddField("gateway");
            return this;
        }

        public OrderTransactionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OrderTransactionQueryBuilder Kind()
        {
            base.InnerQuery.AddField("kind");
            return this;
        }

        public OrderTransactionQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public OrderTransactionQueryBuilder ManuallyCapturable()
        {
            base.InnerQuery.AddField("manuallyCapturable");
            return this;
        }

        public OrderTransactionQueryBuilder ManualPaymentGateway()
        {
            base.InnerQuery.AddField("manualPaymentGateway");
            return this;
        }

        [Obsolete("Use `maximumRefundableV2` instead.")]
        public OrderTransactionQueryBuilder MaximumRefundable()
        {
            base.InnerQuery.AddField("maximumRefundable");
            return this;
        }

        public OrderTransactionQueryBuilder MaximumRefundableV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maximumRefundableV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public OrderTransactionQueryBuilder MultiCapturable()
        {
            base.InnerQuery.AddField("multiCapturable");
            return this;
        }

        public OrderTransactionQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderTransactionQueryBuilder ParentTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("parentTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public OrderTransactionQueryBuilder PaymentIcon(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("paymentIcon");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public OrderTransactionQueryBuilder PaymentId()
        {
            base.InnerQuery.AddField("paymentId");
            return this;
        }

        [Obsolete("Use `paymentIcon` instead.")]
        public OrderTransactionQueryBuilder PaymentMethod()
        {
            base.InnerQuery.AddField("paymentMethod");
            return this;
        }

        public OrderTransactionQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public OrderTransactionQueryBuilder ReceiptJson()
        {
            base.InnerQuery.AddField("receiptJson");
            return this;
        }

        public OrderTransactionQueryBuilder SettlementCurrency()
        {
            base.InnerQuery.AddField("settlementCurrency");
            return this;
        }

        public OrderTransactionQueryBuilder SettlementCurrencyRate()
        {
            base.InnerQuery.AddField("settlementCurrencyRate");
            return this;
        }

        public OrderTransactionQueryBuilder ShopifyPaymentsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsTransactionSetQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsTransactionSet>("shopifyPaymentsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsTransactionSetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsTransactionSet>(query);
            return this;
        }

        public OrderTransactionQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public OrderTransactionQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        [Obsolete("Use `totalUnsettledSet` instead.")]
        public OrderTransactionQueryBuilder TotalUnsettled()
        {
            base.InnerQuery.AddField("totalUnsettled");
            return this;
        }

        public OrderTransactionQueryBuilder TotalUnsettledSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalUnsettledSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderTransactionQueryBuilder TotalUnsettledV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalUnsettledV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public OrderTransactionQueryBuilder User(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("user");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public OrderTransactionQueryBuilder PaymentDetails(Action<PaymentDetailsUnionCasesBuilder> build)
        {
            var query = new Query<PaymentDetails>("paymentDetails");
            var unionBuilder = new PaymentDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}