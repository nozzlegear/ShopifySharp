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
    public sealed class ShopifyPaymentsPayoutSummaryQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutSummary, ShopifyPaymentsPayoutSummaryQueryBuilder>
    {
        protected override ShopifyPaymentsPayoutSummaryQueryBuilder Self => this;

        public ShopifyPaymentsPayoutSummaryQueryBuilder() : this("shopifyPaymentsPayoutSummary")
        {
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutSummary>(name))
        {
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder(IQuery<ShopifyPaymentsPayoutSummary> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder AdjustmentsFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("adjustmentsFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder AdjustmentsGross(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("adjustmentsGross");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder AdvanceFees(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("advanceFees");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder AdvanceGross(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("advanceGross");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder ChargesFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("chargesFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder ChargesGross(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("chargesGross");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder RefundsFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("refundsFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder RefundsFeeGross(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("refundsFeeGross");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder ReservedFundsFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("reservedFundsFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder ReservedFundsGross(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("reservedFundsGross");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder RetriedPayoutsFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("retriedPayoutsFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder RetriedPayoutsGross(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("retriedPayoutsGross");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsPayoutSummaryQueryBuilder UsdcRebateCreditAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("usdcRebateCreditAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}