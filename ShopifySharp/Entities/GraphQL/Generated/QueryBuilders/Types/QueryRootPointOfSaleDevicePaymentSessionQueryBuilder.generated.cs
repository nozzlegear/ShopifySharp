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
    public sealed class QueryRootPointOfSaleDevicePaymentSessionQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSession, QueryRootPointOfSaleDevicePaymentSessionQueryBuilder>, IHasArguments<QueryRootPointOfSaleDevicePaymentSessionArgumentsBuilder>
    {
        public QueryRootPointOfSaleDevicePaymentSessionArgumentsBuilder Arguments { get; }
        protected override QueryRootPointOfSaleDevicePaymentSessionQueryBuilder Self => this;

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSession>(name))
        {
            Arguments = new QueryRootPointOfSaleDevicePaymentSessionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder(IQuery<PointOfSaleDevicePaymentSession> query) : base(query)
        {
            Arguments = new QueryRootPointOfSaleDevicePaymentSessionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder SetArguments(Action<QueryRootPointOfSaleDevicePaymentSessionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder CashActivities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder> build)
        {
            var query = new Query<CashActivityConnection>("cashActivities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashActivityConnection>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder CashCountedAtClose(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashCountedAtClose");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder CashCountedAtOpen(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashCountedAtOpen");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder ClosingAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder ClosingBalance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("closingBalance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder ClosingNote()
        {
            base.InnerQuery.AddField("closingNote");
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder ClosingStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("closingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder ClosingTime()
        {
            base.InnerQuery.AddField("closingTime");
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder ExpectedCashAtClose(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedCashAtClose");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder ExpectedCashAtOpen(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("expectedCashAtOpen");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder NetCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder NetSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder OpeningNote()
        {
            base.InnerQuery.AddField("openingNote");
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder OpeningStaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("openingStaffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder OpeningTime()
        {
            base.InnerQuery.AddField("openingTime");
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder PointOfSaleDevice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("pointOfSaleDevice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder TotalAdjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder TotalCashRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder TotalCashSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalCashSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder TotalDiscrepancy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder TotalRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionQueryBuilder TotalsReady()
        {
            base.InnerQuery.AddField("totalsReady");
            return this;
        }
    }
}