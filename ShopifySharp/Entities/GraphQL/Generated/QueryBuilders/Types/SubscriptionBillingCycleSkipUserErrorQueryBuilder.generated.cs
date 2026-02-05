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
    public sealed class SubscriptionBillingCycleSkipUserErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleSkipUserError, SubscriptionBillingCycleSkipUserErrorQueryBuilder>
    {
        protected override SubscriptionBillingCycleSkipUserErrorQueryBuilder Self => this;

        public SubscriptionBillingCycleSkipUserErrorQueryBuilder() : this("subscriptionBillingCycleSkipUserError")
        {
        }

        public SubscriptionBillingCycleSkipUserErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleSkipUserError>(name))
        {
        }

        public SubscriptionBillingCycleSkipUserErrorQueryBuilder(IQuery<SubscriptionBillingCycleSkipUserError> query) : base(query)
        {
        }

        public SubscriptionBillingCycleSkipUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingCycleSkipUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SubscriptionBillingCycleSkipUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}