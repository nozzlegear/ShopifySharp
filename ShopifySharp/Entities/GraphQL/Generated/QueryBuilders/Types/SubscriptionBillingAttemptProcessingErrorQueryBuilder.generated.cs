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
    public sealed class SubscriptionBillingAttemptProcessingErrorQueryBuilder : FieldsQueryBuilderBase<ISubscriptionBillingAttemptProcessingError, SubscriptionBillingAttemptProcessingErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptProcessingErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder() : this("subscriptionBillingAttemptProcessingError")
        {
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder(string name) : base(new Query<ISubscriptionBillingAttemptProcessingError>(name))
        {
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder(IQuery<ISubscriptionBillingAttemptProcessingError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}