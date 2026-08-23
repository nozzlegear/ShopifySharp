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
    public sealed class SubscriptionBillingAttemptPendingStateQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptPendingState, SubscriptionBillingAttemptPendingStateQueryBuilder>
    {
        protected override SubscriptionBillingAttemptPendingStateQueryBuilder Self => this;

        public SubscriptionBillingAttemptPendingStateQueryBuilder() : this("subscriptionBillingAttemptPendingState")
        {
        }

        public SubscriptionBillingAttemptPendingStateQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptPendingState>(name))
        {
        }

        public SubscriptionBillingAttemptPendingStateQueryBuilder(IQuery<SubscriptionBillingAttemptPendingState> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptPendingStateQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }
    }
}