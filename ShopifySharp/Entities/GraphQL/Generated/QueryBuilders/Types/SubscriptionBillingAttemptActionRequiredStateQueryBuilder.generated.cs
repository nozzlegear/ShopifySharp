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
    public sealed class SubscriptionBillingAttemptActionRequiredStateQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptActionRequiredState, SubscriptionBillingAttemptActionRequiredStateQueryBuilder>
    {
        protected override SubscriptionBillingAttemptActionRequiredStateQueryBuilder Self => this;

        public SubscriptionBillingAttemptActionRequiredStateQueryBuilder() : this("subscriptionBillingAttemptActionRequiredState")
        {
        }

        public SubscriptionBillingAttemptActionRequiredStateQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptActionRequiredState>(name))
        {
        }

        public SubscriptionBillingAttemptActionRequiredStateQueryBuilder(IQuery<SubscriptionBillingAttemptActionRequiredState> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptActionRequiredStateQueryBuilder Action(Action<SubscriptionBillingAttemptActionUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptAction>("action");
            var unionBuilder = new SubscriptionBillingAttemptActionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}