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
    public sealed class SubscriptionBillingAttemptFailedStateQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptFailedState, SubscriptionBillingAttemptFailedStateQueryBuilder>
    {
        protected override SubscriptionBillingAttemptFailedStateQueryBuilder Self => this;

        public SubscriptionBillingAttemptFailedStateQueryBuilder() : this("subscriptionBillingAttemptFailedState")
        {
        }

        public SubscriptionBillingAttemptFailedStateQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptFailedState>(name))
        {
        }

        public SubscriptionBillingAttemptFailedStateQueryBuilder(IQuery<SubscriptionBillingAttemptFailedState> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptFailedStateQueryBuilder Error(Action<SubscriptionBillingAttemptErrorUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptError>("error");
            var unionBuilder = new SubscriptionBillingAttemptErrorUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}