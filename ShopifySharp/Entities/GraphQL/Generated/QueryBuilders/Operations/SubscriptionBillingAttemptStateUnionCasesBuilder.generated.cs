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
    public sealed class SubscriptionBillingAttemptStateUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionBillingAttemptState, SubscriptionBillingAttemptStateUnionCasesBuilder>
    {
        protected override SubscriptionBillingAttemptStateUnionCasesBuilder Self => this;

        public SubscriptionBillingAttemptStateUnionCasesBuilder(string fieldName = "state") : this(new Query<SubscriptionBillingAttemptState>(fieldName))
        {
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder(IQuery<SubscriptionBillingAttemptState> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptActionRequiredState(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptActionRequiredStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptActionRequiredState>("... on SubscriptionBillingAttemptActionRequiredState");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptActionRequiredStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptFailedState(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptFailedStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptFailedState>("... on SubscriptionBillingAttemptFailedState");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptFailedStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptPendingState(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptPendingStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptPendingState>("... on SubscriptionBillingAttemptPendingState");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptPendingStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptStateUnionCasesBuilder OnSubscriptionBillingAttemptSuccessState(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptSuccessStateQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptSuccessState>("... on SubscriptionBillingAttemptSuccessState");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptSuccessStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}