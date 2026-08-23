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
    public sealed class SubscriptionBillingAttemptPaymentErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptPaymentError, SubscriptionBillingAttemptPaymentErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptPaymentErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptPaymentErrorQueryBuilder() : this("subscriptionBillingAttemptPaymentError")
        {
        }

        public SubscriptionBillingAttemptPaymentErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptPaymentError>(name))
        {
        }

        public SubscriptionBillingAttemptPaymentErrorQueryBuilder(IQuery<SubscriptionBillingAttemptPaymentError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptPaymentErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }
    }
}