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
    public sealed class SubscriptionBillingAttemptUnexpectedErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptUnexpectedError, SubscriptionBillingAttemptUnexpectedErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptUnexpectedErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptUnexpectedErrorQueryBuilder() : this("subscriptionBillingAttemptUnexpectedError")
        {
        }

        public SubscriptionBillingAttemptUnexpectedErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptUnexpectedError>(name))
        {
        }

        public SubscriptionBillingAttemptUnexpectedErrorQueryBuilder(IQuery<SubscriptionBillingAttemptUnexpectedError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptUnexpectedErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}