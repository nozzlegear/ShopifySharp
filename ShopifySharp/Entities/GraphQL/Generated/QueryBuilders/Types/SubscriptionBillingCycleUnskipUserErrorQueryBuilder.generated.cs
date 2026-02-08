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
    public sealed class SubscriptionBillingCycleUnskipUserErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleUnskipUserError, SubscriptionBillingCycleUnskipUserErrorQueryBuilder>
    {
        protected override SubscriptionBillingCycleUnskipUserErrorQueryBuilder Self => this;

        public SubscriptionBillingCycleUnskipUserErrorQueryBuilder() : this("subscriptionBillingCycleUnskipUserError")
        {
        }

        public SubscriptionBillingCycleUnskipUserErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleUnskipUserError>(name))
        {
        }

        public SubscriptionBillingCycleUnskipUserErrorQueryBuilder(IQuery<SubscriptionBillingCycleUnskipUserError> query) : base(query)
        {
        }

        public SubscriptionBillingCycleUnskipUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingCycleUnskipUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SubscriptionBillingCycleUnskipUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}