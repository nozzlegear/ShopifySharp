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
    public sealed class SubscriptionBillingCycleScheduleEditPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleScheduleEditPayload, SubscriptionBillingCycleScheduleEditPayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleScheduleEditPayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder() : this("subscriptionBillingCycleScheduleEditPayload")
        {
        }

        public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleScheduleEditPayload>(name))
        {
        }

        public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder(IQuery<SubscriptionBillingCycleScheduleEditPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUserError>(query);
            return this;
        }
    }
}