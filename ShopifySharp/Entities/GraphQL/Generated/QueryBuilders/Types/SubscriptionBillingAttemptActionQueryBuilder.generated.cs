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
    public sealed class SubscriptionBillingAttemptActionQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptAction, SubscriptionBillingAttemptActionQueryBuilder>
    {
        protected override SubscriptionBillingAttemptActionQueryBuilder Self => this;

        public SubscriptionBillingAttemptActionQueryBuilder() : this("subscriptionBillingAttemptAction")
        {
        }

        public SubscriptionBillingAttemptActionQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptAction>(name))
        {
        }

        public SubscriptionBillingAttemptActionQueryBuilder(IQuery<SubscriptionBillingAttemptAction> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptActionQueryBuilder SubscriptionBillingAttemptAction(Action<SubscriptionBillingAttemptActionUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptAction>("subscriptionBillingAttemptAction");
            var unionBuilder = new SubscriptionBillingAttemptActionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}