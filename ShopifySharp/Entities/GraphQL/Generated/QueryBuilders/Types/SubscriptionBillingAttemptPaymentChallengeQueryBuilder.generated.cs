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
    public sealed class SubscriptionBillingAttemptPaymentChallengeQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptPaymentChallenge, SubscriptionBillingAttemptPaymentChallengeQueryBuilder>
    {
        protected override SubscriptionBillingAttemptPaymentChallengeQueryBuilder Self => this;

        public SubscriptionBillingAttemptPaymentChallengeQueryBuilder() : this("subscriptionBillingAttemptPaymentChallenge")
        {
        }

        public SubscriptionBillingAttemptPaymentChallengeQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptPaymentChallenge>(name))
        {
        }

        public SubscriptionBillingAttemptPaymentChallengeQueryBuilder(IQuery<SubscriptionBillingAttemptPaymentChallenge> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptPaymentChallengeQueryBuilder NextActionUrl()
        {
            base.InnerQuery.AddField("nextActionUrl");
            return this;
        }

        public SubscriptionBillingAttemptPaymentChallengeQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}