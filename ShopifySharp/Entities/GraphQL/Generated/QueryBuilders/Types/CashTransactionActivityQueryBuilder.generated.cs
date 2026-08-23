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
    public sealed class CashTransactionActivityQueryBuilder : FieldsQueryBuilderBase<CashTransactionActivity, CashTransactionActivityQueryBuilder>
    {
        protected override CashTransactionActivityQueryBuilder Self => this;

        public CashTransactionActivityQueryBuilder() : this("cashTransactionActivity")
        {
        }

        public CashTransactionActivityQueryBuilder(string name) : base(new Query<CashTransactionActivity>(name))
        {
        }

        public CashTransactionActivityQueryBuilder(IQuery<CashTransactionActivity> query) : base(query)
        {
        }

        public CashTransactionActivityQueryBuilder Cash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTransactionActivityQueryBuilder OrderTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("orderTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public CashTransactionActivityQueryBuilder PaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("paymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public CashTransactionActivityQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashTransactionActivityQueryBuilder Time()
        {
            base.InnerQuery.AddField("time");
            return this;
        }

        public CashTransactionActivityQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}