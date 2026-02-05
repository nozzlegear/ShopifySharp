#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ShopifyPaymentsPayoutScheduleQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutSchedule, ShopifyPaymentsPayoutScheduleQueryBuilder>
    {
        protected override ShopifyPaymentsPayoutScheduleQueryBuilder Self => this;

        public ShopifyPaymentsPayoutScheduleQueryBuilder() : this("shopifyPaymentsPayoutSchedule")
        {
        }

        public ShopifyPaymentsPayoutScheduleQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutSchedule>(name))
        {
        }

        public ShopifyPaymentsPayoutScheduleQueryBuilder(IQuery<ShopifyPaymentsPayoutSchedule> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutScheduleQueryBuilder Interval()
        {
            base.InnerQuery.AddField("interval");
            return this;
        }

        public ShopifyPaymentsPayoutScheduleQueryBuilder MonthlyAnchor()
        {
            base.InnerQuery.AddField("monthlyAnchor");
            return this;
        }

        public ShopifyPaymentsPayoutScheduleQueryBuilder WeeklyAnchor()
        {
            base.InnerQuery.AddField("weeklyAnchor");
            return this;
        }
    }
}