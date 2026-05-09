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
    public sealed class SubscriptionBillingAttemptStateQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptState, SubscriptionBillingAttemptStateQueryBuilder>
    {
        protected override SubscriptionBillingAttemptStateQueryBuilder Self => this;

        public SubscriptionBillingAttemptStateQueryBuilder() : this("subscriptionBillingAttemptState")
        {
        }

        public SubscriptionBillingAttemptStateQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptState>(name))
        {
        }

        public SubscriptionBillingAttemptStateQueryBuilder(IQuery<SubscriptionBillingAttemptState> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptStateQueryBuilder SubscriptionBillingAttemptState(Action<SubscriptionBillingAttemptStateUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptState>("subscriptionBillingAttemptState");
            var unionBuilder = new SubscriptionBillingAttemptStateUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}