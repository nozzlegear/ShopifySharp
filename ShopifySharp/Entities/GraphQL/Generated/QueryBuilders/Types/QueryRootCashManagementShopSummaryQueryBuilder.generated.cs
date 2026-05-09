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
    public sealed class QueryRootCashManagementShopSummaryQueryBuilder : FieldsQueryBuilderBase<CashManagementSummary, QueryRootCashManagementShopSummaryQueryBuilder>, IHasArguments<QueryRootCashManagementShopSummaryArgumentsBuilder>
    {
        public QueryRootCashManagementShopSummaryArgumentsBuilder Arguments { get; }
        protected override QueryRootCashManagementShopSummaryQueryBuilder Self => this;

        public QueryRootCashManagementShopSummaryQueryBuilder(string name) : base(new Query<CashManagementSummary>(name))
        {
            Arguments = new QueryRootCashManagementShopSummaryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashManagementShopSummaryQueryBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
            Arguments = new QueryRootCashManagementShopSummaryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashManagementShopSummaryQueryBuilder SetArguments(Action<QueryRootCashManagementShopSummaryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCashManagementShopSummaryQueryBuilder CashBalanceAtEnd(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtEnd");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashManagementShopSummaryQueryBuilder CashBalanceAtStart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtStart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashManagementShopSummaryQueryBuilder NetCash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashManagementShopSummaryQueryBuilder SessionsClosed()
        {
            base.InnerQuery.AddField("sessionsClosed");
            return this;
        }

        public QueryRootCashManagementShopSummaryQueryBuilder SessionsOpened()
        {
            base.InnerQuery.AddField("sessionsOpened");
            return this;
        }

        public QueryRootCashManagementShopSummaryQueryBuilder TotalDiscrepancies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}