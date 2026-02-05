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
    public sealed class CashTrackingSessionQueryBuilder : FieldsQueryBuilderBase<CashTrackingSession, CashTrackingSessionQueryBuilder>
    {
        protected override CashTrackingSessionQueryBuilder Self => this;

        public CashTrackingSessionQueryBuilder() : this("cashTrackingSession")
        {
        }

        public CashTrackingSessionQueryBuilder(string name) : base(new Query<CashTrackingSession>(name))
        {
        }

        public CashTrackingSessionQueryBuilder(IQuery<CashTrackingSession> query) : base(query)
        {
        }

        public CashTrackingSessionQueryBuilder Adjustments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashTrackingAdjustmentConnectionQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustmentConnection>("adjustments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CashTrackingAdjustmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingAdjustmentConnection>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder CashTrackingEnabled()
        {
            base.InnerQuery.AddField("cashTrackingEnabled");
            return this;
        }

        public CashTrackingSessionQueryBuilder CashTransactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("cashTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder ClosingBalance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder ClosingNote()
        {
            base.InnerQuery.AddField("closingNote");
            return this;
        }

        public CashTrackingSessionQueryBuilder ClosingStaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("closingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder ClosingTime()
        {
            base.InnerQuery.AddField("closingTime");
            return this;
        }

        public CashTrackingSessionQueryBuilder ExpectedBalance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedBalance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder ExpectedClosingBalance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedClosingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder ExpectedOpeningBalance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedOpeningBalance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CashTrackingSessionQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder NetCashSales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder OpeningBalance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("openingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder OpeningNote()
        {
            base.InnerQuery.AddField("openingNote");
            return this;
        }

        public CashTrackingSessionQueryBuilder OpeningStaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("openingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder OpeningTime()
        {
            base.InnerQuery.AddField("openingTime");
            return this;
        }

        public CashTrackingSessionQueryBuilder RegisterName()
        {
            base.InnerQuery.AddField("registerName");
            return this;
        }

        public CashTrackingSessionQueryBuilder TotalAdjustments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder TotalCashRefunds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder TotalCashSales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionQueryBuilder TotalDiscrepancy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}