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
    public sealed class SubscriptionBillingAttemptStateUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionBillingAttemptState, SubscriptionBillingAttemptStateUnionCasesBuilder>
    {
        protected override SubscriptionBillingAttemptStateUnionCasesBuilder Self => this;

        public SubscriptionBillingAttemptStateUnionCasesBuilder(string fieldName = "subscriptionBillingAttemptState") : this(new Query<SubscriptionBillingAttemptState>(fieldName))
        {
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder(IQuery<SubscriptionBillingAttemptState> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptActionRequiredState(Action<SubscriptionBillingAttemptActionRequiredStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptActionRequiredState>("... on SubscriptionBillingAttemptActionRequiredState");
            var queryBuilder = new SubscriptionBillingAttemptActionRequiredStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptFailedState(Action<SubscriptionBillingAttemptFailedStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptFailedState>("... on SubscriptionBillingAttemptFailedState");
            var queryBuilder = new SubscriptionBillingAttemptFailedStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptPendingState(Action<SubscriptionBillingAttemptPendingStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptPendingState>("... on SubscriptionBillingAttemptPendingState");
            var queryBuilder = new SubscriptionBillingAttemptPendingStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptSuccessState(Action<SubscriptionBillingAttemptSuccessStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptSuccessState>("... on SubscriptionBillingAttemptSuccessState");
            var queryBuilder = new SubscriptionBillingAttemptSuccessStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}