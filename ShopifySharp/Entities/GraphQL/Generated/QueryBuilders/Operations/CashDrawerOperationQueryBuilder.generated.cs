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
    public sealed class CashDrawerOperationQueryBuilder : FieldsQueryBuilderBase<CashDrawer, CashDrawerOperationQueryBuilder>, IGraphOperationQueryBuilder<CashDrawer>, IHasArguments<CashDrawerArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CashDrawerArgumentsBuilder Arguments { get; }
        protected override CashDrawerOperationQueryBuilder Self => this;

        public CashDrawerOperationQueryBuilder() : this("cashDrawer")
        {
        }

        public CashDrawerOperationQueryBuilder(string name) : base(new Query<CashDrawer>(name))
        {
            Arguments = new CashDrawerArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerOperationQueryBuilder(IQuery<CashDrawer> query) : base(query)
        {
            Arguments = new CashDrawerArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerOperationQueryBuilder SetArguments(Action<CashDrawerArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerOperationQueryBuilder CashActivities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder> build)
        {
            var query = new Query<CashActivityConnection>("cashActivities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashActivityConnection>(query);
            return this;
        }

        public CashDrawerOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CashDrawerOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public CashDrawerOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CashDrawerOperationQueryBuilder NetSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashDrawerOperationQueryBuilder PointOfSaleDevices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceConnectionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDeviceConnection>("pointOfSaleDevices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDeviceConnection>(query);
            return this;
        }

        public CashDrawerOperationQueryBuilder TotalAdjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashDrawerOperationQueryBuilder TotalDiscrepancies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashDrawerOperationQueryBuilder TotalRefunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalRefunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashDrawerOperationQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}