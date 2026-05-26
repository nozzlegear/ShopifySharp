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
    public sealed class PointOfSaleDevicePaymentSessionOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSession, PointOfSaleDevicePaymentSessionOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevicePaymentSession>, IHasArguments<PointOfSaleDevicePaymentSessionArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PointOfSaleDevicePaymentSessionArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionOperationQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder() : this("pointOfSaleDevicePaymentSession")
        {
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSession>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder(IQuery<PointOfSaleDevicePaymentSession> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder CashActivities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder> build)
        {
            var query = new Query<CashActivityConnection>("cashActivities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashActivityConnection>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder CashCountedAtClose(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashCountedAtClose");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder CashCountedAtOpen(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashCountedAtOpen");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder ClosingAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder ClosingBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder ClosingNote()
        {
            base.InnerQuery.AddField("closingNote");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder ClosingStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("closingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder ClosingTime()
        {
            base.InnerQuery.AddField("closingTime");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder ExpectedCashAtClose(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedCashAtClose");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder ExpectedCashAtOpen(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedCashAtOpen");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder NetCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder NetSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder OpeningNote()
        {
            base.InnerQuery.AddField("openingNote");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder OpeningStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("openingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder OpeningTime()
        {
            base.InnerQuery.AddField("openingTime");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder PointOfSaleDevice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("pointOfSaleDevice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder TotalAdjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder TotalCashRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder TotalCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder TotalDiscrepancy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder TotalRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOperationQueryBuilder TotalsReady()
        {
            base.InnerQuery.AddField("totalsReady");
            return this;
        }
    }
}