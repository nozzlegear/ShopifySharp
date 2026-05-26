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
    public sealed class SubscriptionBillingAttemptErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptError, SubscriptionBillingAttemptErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptErrorQueryBuilder() : this("subscriptionBillingAttemptError")
        {
        }

        public SubscriptionBillingAttemptErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptError>(name))
        {
        }

        public SubscriptionBillingAttemptErrorQueryBuilder(IQuery<SubscriptionBillingAttemptError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptErrorQueryBuilder SubscriptionBillingAttemptError(Action<SubscriptionBillingAttemptErrorUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptError>("subscriptionBillingAttemptError");
            var unionBuilder = new SubscriptionBillingAttemptErrorUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}