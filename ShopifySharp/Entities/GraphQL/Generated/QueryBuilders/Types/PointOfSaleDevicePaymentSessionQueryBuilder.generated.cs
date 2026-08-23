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
    public sealed class PointOfSaleDevicePaymentSessionQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSession, PointOfSaleDevicePaymentSessionQueryBuilder>, IHasArguments<PointOfSaleDevicePaymentSessionArgumentsBuilder>
    {
        public PointOfSaleDevicePaymentSessionArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionQueryBuilder() : this("pointOfSaleDevicePaymentSession")
        {
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSession>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder(IQuery<PointOfSaleDevicePaymentSession> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder CashActivities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder> build)
        {
            var query = new Query<CashActivityConnection>("cashActivities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashActivityConnection>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder CashCountedAtClose(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashCountedAtClose");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder CashCountedAtOpen(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashCountedAtOpen");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder ClosingAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder ClosingBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder ClosingNote()
        {
            base.InnerQuery.AddField("closingNote");
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder ClosingStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("closingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder ClosingTime()
        {
            base.InnerQuery.AddField("closingTime");
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder ExpectedCashAtClose(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedCashAtClose");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder ExpectedCashAtOpen(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedCashAtOpen");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder NetCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder NetSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder OpeningNote()
        {
            base.InnerQuery.AddField("openingNote");
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder OpeningStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("openingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder OpeningTime()
        {
            base.InnerQuery.AddField("openingTime");
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder PointOfSaleDevice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("pointOfSaleDevice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder TotalAdjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder TotalCashRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder TotalCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder TotalDiscrepancy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder TotalRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionQueryBuilder TotalsReady()
        {
            base.InnerQuery.AddField("totalsReady");
            return this;
        }
    }
}