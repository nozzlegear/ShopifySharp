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
    public sealed class QueryRootCashDrawerQueryBuilder : FieldsQueryBuilderBase<CashDrawer, QueryRootCashDrawerQueryBuilder>, IHasArguments<QueryRootCashDrawerArgumentsBuilder>
    {
        public QueryRootCashDrawerArgumentsBuilder Arguments { get; }
        protected override QueryRootCashDrawerQueryBuilder Self => this;

        public QueryRootCashDrawerQueryBuilder(string name) : base(new Query<CashDrawer>(name))
        {
            Arguments = new QueryRootCashDrawerArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashDrawerQueryBuilder(IQuery<CashDrawer> query) : base(query)
        {
            Arguments = new QueryRootCashDrawerArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashDrawerQueryBuilder SetArguments(Action<QueryRootCashDrawerArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder CashActivities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder> build)
        {
            var query = new Query<CashActivityConnection>("cashActivities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashActivityConnection>(query);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCashDrawerQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootCashDrawerQueryBuilder NetSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder PointOfSaleDevices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceConnectionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDeviceConnection>("pointOfSaleDevices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDeviceConnection>(query);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder TotalAdjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder TotalDiscrepancies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder TotalRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashDrawerQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}