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
    public sealed class SubscriptionBillingCycleEditsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleEditsDeletePayload, SubscriptionBillingCycleEditsDeletePayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleEditsDeletePayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder() : this("subscriptionBillingCycleEditsDeletePayload")
        {
        }

        public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleEditsDeletePayload>(name))
        {
        }

        public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder(IQuery<SubscriptionBillingCycleEditsDeletePayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder BillingCycles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUserError>(query);
            return this;
        }
    }
}