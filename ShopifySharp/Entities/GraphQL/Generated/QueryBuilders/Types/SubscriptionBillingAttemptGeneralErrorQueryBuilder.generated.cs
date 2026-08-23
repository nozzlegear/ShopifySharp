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
    public sealed class SubscriptionBillingAttemptGeneralErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptGeneralError, SubscriptionBillingAttemptGeneralErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptGeneralErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptGeneralErrorQueryBuilder() : this("subscriptionBillingAttemptGeneralError")
        {
        }

        public SubscriptionBillingAttemptGeneralErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptGeneralError>(name))
        {
        }

        public SubscriptionBillingAttemptGeneralErrorQueryBuilder(IQuery<SubscriptionBillingAttemptGeneralError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptGeneralErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }
    }
}