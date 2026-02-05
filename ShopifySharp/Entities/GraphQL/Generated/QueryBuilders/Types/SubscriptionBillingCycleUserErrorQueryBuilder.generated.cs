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
    public sealed class SubscriptionBillingCycleUserErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleUserError, SubscriptionBillingCycleUserErrorQueryBuilder>
    {
        protected override SubscriptionBillingCycleUserErrorQueryBuilder Self => this;

        public SubscriptionBillingCycleUserErrorQueryBuilder() : this("subscriptionBillingCycleUserError")
        {
        }

        public SubscriptionBillingCycleUserErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleUserError>(name))
        {
        }

        public SubscriptionBillingCycleUserErrorQueryBuilder(IQuery<SubscriptionBillingCycleUserError> query) : base(query)
        {
        }

        public SubscriptionBillingCycleUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingCycleUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SubscriptionBillingCycleUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}