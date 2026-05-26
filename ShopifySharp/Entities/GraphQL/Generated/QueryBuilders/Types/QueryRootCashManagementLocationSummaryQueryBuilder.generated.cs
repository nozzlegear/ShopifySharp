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
    public sealed class QueryRootCashManagementLocationSummaryQueryBuilder : FieldsQueryBuilderBase<CashManagementSummary, QueryRootCashManagementLocationSummaryQueryBuilder>, IHasArguments<QueryRootCashManagementLocationSummaryArgumentsBuilder>
    {
        public QueryRootCashManagementLocationSummaryArgumentsBuilder Arguments { get; }
        protected override QueryRootCashManagementLocationSummaryQueryBuilder Self => this;

        public QueryRootCashManagementLocationSummaryQueryBuilder(string name) : base(new Query<CashManagementSummary>(name))
        {
            Arguments = new QueryRootCashManagementLocationSummaryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
            Arguments = new QueryRootCashManagementLocationSummaryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder SetArguments(Action<QueryRootCashManagementLocationSummaryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder CashBalanceAtEnd(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtEnd");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder CashBalanceAtStart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtStart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder NetCash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder SessionsClosed()
        {
            base.InnerQuery.AddField("sessionsClosed");
            return this;
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder SessionsOpened()
        {
            base.InnerQuery.AddField("sessionsOpened");
            return this;
        }

        public QueryRootCashManagementLocationSummaryQueryBuilder TotalDiscrepancies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}