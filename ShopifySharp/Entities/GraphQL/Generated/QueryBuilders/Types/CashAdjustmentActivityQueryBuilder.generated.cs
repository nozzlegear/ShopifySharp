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
    public sealed class CashAdjustmentActivityQueryBuilder : FieldsQueryBuilderBase<CashAdjustmentActivity, CashAdjustmentActivityQueryBuilder>
    {
        protected override CashAdjustmentActivityQueryBuilder Self => this;

        public CashAdjustmentActivityQueryBuilder() : this("cashAdjustmentActivity")
        {
        }

        public CashAdjustmentActivityQueryBuilder(string name) : base(new Query<CashAdjustmentActivity>(name))
        {
        }

        public CashAdjustmentActivityQueryBuilder(IQuery<CashAdjustmentActivity> query) : base(query)
        {
        }

        public CashAdjustmentActivityQueryBuilder Cash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashAdjustmentActivityQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public CashAdjustmentActivityQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CashAdjustmentActivityQueryBuilder PaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("paymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public CashAdjustmentActivityQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashAdjustmentActivityQueryBuilder Time()
        {
            base.InnerQuery.AddField("time");
            return this;
        }

        public CashAdjustmentActivityQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public CashAdjustmentActivityQueryBuilder ReasonCode(Action<CashManagementReasonCodeUnionCasesBuilder> build)
        {
            var query = new Query<CashManagementReasonCode>("reasonCode");
            var unionBuilder = new CashManagementReasonCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}