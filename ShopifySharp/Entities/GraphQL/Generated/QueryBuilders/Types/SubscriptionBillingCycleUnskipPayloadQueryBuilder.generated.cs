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
    public sealed class SubscriptionBillingCycleUnskipPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleUnskipPayload, SubscriptionBillingCycleUnskipPayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleUnskipPayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleUnskipPayloadQueryBuilder() : this("subscriptionBillingCycleUnskipPayload")
        {
        }

        public SubscriptionBillingCycleUnskipPayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleUnskipPayload>(name))
        {
        }

        public SubscriptionBillingCycleUnskipPayloadQueryBuilder(IQuery<SubscriptionBillingCycleUnskipPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleUnskipPayloadQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleUnskipPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUnskipUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUnskipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUnskipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUnskipUserError>(query);
            return this;
        }
    }
}