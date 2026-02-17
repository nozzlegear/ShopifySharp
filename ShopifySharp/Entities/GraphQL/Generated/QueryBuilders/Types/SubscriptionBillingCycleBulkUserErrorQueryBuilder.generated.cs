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
    public sealed class SubscriptionBillingCycleBulkUserErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleBulkUserError, SubscriptionBillingCycleBulkUserErrorQueryBuilder>
    {
        protected override SubscriptionBillingCycleBulkUserErrorQueryBuilder Self => this;

        public SubscriptionBillingCycleBulkUserErrorQueryBuilder() : this("subscriptionBillingCycleBulkUserError")
        {
        }

        public SubscriptionBillingCycleBulkUserErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleBulkUserError>(name))
        {
        }

        public SubscriptionBillingCycleBulkUserErrorQueryBuilder(IQuery<SubscriptionBillingCycleBulkUserError> query) : base(query)
        {
        }

        public SubscriptionBillingCycleBulkUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingCycleBulkUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SubscriptionBillingCycleBulkUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}