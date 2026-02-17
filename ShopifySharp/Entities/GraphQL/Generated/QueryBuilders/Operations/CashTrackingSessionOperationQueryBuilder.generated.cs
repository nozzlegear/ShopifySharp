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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CashTrackingSessionOperationQueryBuilder : FieldsQueryBuilderBase<CashTrackingSession, CashTrackingSessionOperationQueryBuilder>, IGraphOperationQueryBuilder<CashTrackingSession>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CashTrackingSessionArgumentsBuilder Arguments { get; }
        protected override CashTrackingSessionOperationQueryBuilder Self => this;

        public CashTrackingSessionOperationQueryBuilder() : this("cashTrackingSession")
        {
        }

        public CashTrackingSessionOperationQueryBuilder(string name) : base(new Query<CashTrackingSession>(name))
        {
            Arguments = new CashTrackingSessionArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionOperationQueryBuilder(IQuery<CashTrackingSession> query) : base(query)
        {
            Arguments = new CashTrackingSessionArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionOperationQueryBuilder Adjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentConnectionQueryBuilder> build)
        {
            var query = new Query<CashTrackingAdjustmentConnection>("adjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTrackingAdjustmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashTrackingAdjustmentConnection>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder CashTrackingEnabled()
        {
            base.InnerQuery.AddField("cashTrackingEnabled");
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder CashTransactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("cashTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder ClosingBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder ClosingNote()
        {
            base.InnerQuery.AddField("closingNote");
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder ClosingStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("closingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder ClosingTime()
        {
            base.InnerQuery.AddField("closingTime");
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder ExpectedBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder ExpectedClosingBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedClosingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder ExpectedOpeningBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedOpeningBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder NetCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder OpeningBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("openingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder OpeningNote()
        {
            base.InnerQuery.AddField("openingNote");
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder OpeningStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("openingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder OpeningTime()
        {
            base.InnerQuery.AddField("openingTime");
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder RegisterName()
        {
            base.InnerQuery.AddField("registerName");
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder TotalAdjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder TotalCashRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder TotalCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingSessionOperationQueryBuilder TotalDiscrepancy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}