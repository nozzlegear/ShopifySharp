#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SubscriptionBillingAttemptGenericErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptGenericError, SubscriptionBillingAttemptGenericErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptGenericErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptGenericErrorQueryBuilder() : this("subscriptionBillingAttemptGenericError")
        {
        }

        public SubscriptionBillingAttemptGenericErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptGenericError>(name))
        {
        }

        public SubscriptionBillingAttemptGenericErrorQueryBuilder(IQuery<SubscriptionBillingAttemptGenericError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptGenericErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingAttemptGenericErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}