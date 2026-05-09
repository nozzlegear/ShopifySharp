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
    public sealed class CashManagementShopSummaryOperationQueryBuilder : FieldsQueryBuilderBase<CashManagementSummary, CashManagementShopSummaryOperationQueryBuilder>, IGraphOperationQueryBuilder<CashManagementSummary>, IHasArguments<CashManagementShopSummaryArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CashManagementShopSummaryArgumentsBuilder Arguments { get; }
        protected override CashManagementShopSummaryOperationQueryBuilder Self => this;

        public CashManagementShopSummaryOperationQueryBuilder() : this("cashManagementShopSummary")
        {
        }

        public CashManagementShopSummaryOperationQueryBuilder(string name) : base(new Query<CashManagementSummary>(name))
        {
            Arguments = new CashManagementShopSummaryArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementShopSummaryOperationQueryBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
            Arguments = new CashManagementShopSummaryArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementShopSummaryOperationQueryBuilder SetArguments(Action<CashManagementShopSummaryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashManagementShopSummaryOperationQueryBuilder CashBalanceAtEnd(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtEnd");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementShopSummaryOperationQueryBuilder CashBalanceAtStart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtStart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementShopSummaryOperationQueryBuilder NetCash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementShopSummaryOperationQueryBuilder SessionsClosed()
        {
            base.InnerQuery.AddField("sessionsClosed");
            return this;
        }

        public CashManagementShopSummaryOperationQueryBuilder SessionsOpened()
        {
            base.InnerQuery.AddField("sessionsOpened");
            return this;
        }

        public CashManagementShopSummaryOperationQueryBuilder TotalDiscrepancies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}