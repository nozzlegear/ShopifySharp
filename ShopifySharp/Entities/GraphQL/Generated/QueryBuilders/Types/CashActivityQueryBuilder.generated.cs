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
    public sealed class CashActivityQueryBuilder : FieldsQueryBuilderBase<ICashActivity, CashActivityQueryBuilder>
    {
        protected override CashActivityQueryBuilder Self => this;

        public CashActivityQueryBuilder() : this("cashActivity")
        {
        }

        public CashActivityQueryBuilder(string name) : base(new Query<ICashActivity>(name))
        {
        }

        public CashActivityQueryBuilder(IQuery<ICashActivity> query) : base(query)
        {
        }

        public CashActivityQueryBuilder Cash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashActivityQueryBuilder PaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("paymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public CashActivityQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashActivityQueryBuilder Time()
        {
            base.InnerQuery.AddField("time");
            return this;
        }

        public CashActivityQueryBuilder OnCashAdjustmentActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashAdjustmentActivityQueryBuilder> build)
        {
            var query = new Query<CashAdjustmentActivity>("... on CashAdjustmentActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashAdjustmentActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CashActivityQueryBuilder OnCashCountActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashCountActivityQueryBuilder> build)
        {
            var query = new Query<CashCountActivity>("... on CashCountActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashCountActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CashActivityQueryBuilder OnCashTransactionActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTransactionActivityQueryBuilder> build)
        {
            var query = new Query<CashTransactionActivity>("... on CashTransactionActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTransactionActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CashActivityQueryBuilder CashActivity(Action<CashActivityInterfaceCasesBuilder> build)
        {
            var query = new Query<ICashActivity>("cashActivity");
            var unionBuilder = new CashActivityInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}