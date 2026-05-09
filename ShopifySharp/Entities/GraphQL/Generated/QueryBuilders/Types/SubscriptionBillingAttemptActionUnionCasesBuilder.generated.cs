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
    public sealed class SubscriptionBillingAttemptActionUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionBillingAttemptAction, SubscriptionBillingAttemptActionUnionCasesBuilder>
    {
        protected override SubscriptionBillingAttemptActionUnionCasesBuilder Self => this;

        public SubscriptionBillingAttemptActionUnionCasesBuilder(string fieldName = "action") : this(new Query<SubscriptionBillingAttemptAction>(fieldName))
        {
        }

        public SubscriptionBillingAttemptActionUnionCasesBuilder(IQuery<SubscriptionBillingAttemptAction> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptActionUnionCasesBuilder OnSubscriptionBillingAttemptPaymentChallenge(Action<SubscriptionBillingAttemptPaymentChallengeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptPaymentChallenge>("... on SubscriptionBillingAttemptPaymentChallenge");
            var queryBuilder = new SubscriptionBillingAttemptPaymentChallengeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}