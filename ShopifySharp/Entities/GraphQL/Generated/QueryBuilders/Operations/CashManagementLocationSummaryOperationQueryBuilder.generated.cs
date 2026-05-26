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
    public sealed class CashManagementLocationSummaryOperationQueryBuilder : FieldsQueryBuilderBase<CashManagementSummary, CashManagementLocationSummaryOperationQueryBuilder>, IGraphOperationQueryBuilder<CashManagementSummary>, IHasArguments<CashManagementLocationSummaryArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CashManagementLocationSummaryArgumentsBuilder Arguments { get; }
        protected override CashManagementLocationSummaryOperationQueryBuilder Self => this;

        public CashManagementLocationSummaryOperationQueryBuilder() : this("cashManagementLocationSummary")
        {
        }

        public CashManagementLocationSummaryOperationQueryBuilder(string name) : base(new Query<CashManagementSummary>(name))
        {
            Arguments = new CashManagementLocationSummaryArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementLocationSummaryOperationQueryBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
            Arguments = new CashManagementLocationSummaryArgumentsBuilder(base.InnerQuery);
        }

        public CashManagementLocationSummaryOperationQueryBuilder SetArguments(Action<CashManagementLocationSummaryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashManagementLocationSummaryOperationQueryBuilder CashBalanceAtEnd(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtEnd");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementLocationSummaryOperationQueryBuilder CashBalanceAtStart(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cashBalanceAtStart");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementLocationSummaryOperationQueryBuilder NetCash(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("netCash");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashManagementLocationSummaryOperationQueryBuilder SessionsClosed()
        {
            base.InnerQuery.AddField("sessionsClosed");
            return this;
        }

        public CashManagementLocationSummaryOperationQueryBuilder SessionsOpened()
        {
            base.InnerQuery.AddField("sessionsOpened");
            return this;
        }

        public CashManagementLocationSummaryOperationQueryBuilder TotalDiscrepancies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscrepancies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}