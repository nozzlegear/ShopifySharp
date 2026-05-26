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
    public sealed class CashManagementSummaryQueryBuilder : FieldsQueryBuilderBase<CashManagementSummary, CashManagementSummaryQueryBuilder>, IHasArguments<CashManagementSummaryArgumentsBuilder>
    {
        public CashManagementSummaryArgumentsBuilder Arguments { get; }
        protected override CashManagementSummaryQueryBuilder Self => this;

        public CashManagementSummaryQueryBuilder() : this("cashManagementSummary")
        {
        }

        public CashManagementSummaryQueryBuilder(string name) : base(new Query<CashManagementSummary>(name))
        {
            Arguments = new CashManagementSummaryArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementSummaryQueryBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
            Arguments = new CashManagementSummaryArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementSummaryQueryBuilder SetArguments(Action<CashManagementSummaryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashManagementSummaryQueryBuilder CashBalanceAtEnd(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtEnd");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementSummaryQueryBuilder CashBalanceAtStart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtStart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementSummaryQueryBuilder NetCash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementSummaryQueryBuilder SessionsClosed()
        {
            base.InnerQuery.AddField("sessionsClosed");
            return this;
        }

        public CashManagementSummaryQueryBuilder SessionsOpened()
        {
            base.InnerQuery.AddField("sessionsOpened");
            return this;
        }

        public CashManagementSummaryQueryBuilder TotalDiscrepancies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}