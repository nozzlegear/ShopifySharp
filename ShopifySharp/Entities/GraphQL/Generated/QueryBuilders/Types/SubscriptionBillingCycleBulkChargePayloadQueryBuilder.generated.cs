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
    public sealed class SubscriptionBillingCycleBulkChargePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleBulkChargePayload, SubscriptionBillingCycleBulkChargePayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleBulkChargePayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleBulkChargePayloadQueryBuilder() : this("subscriptionBillingCycleBulkChargePayload")
        {
        }

        public SubscriptionBillingCycleBulkChargePayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleBulkChargePayload>(name))
        {
        }

        public SubscriptionBillingCycleBulkChargePayloadQueryBuilder(IQuery<SubscriptionBillingCycleBulkChargePayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleBulkChargePayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public SubscriptionBillingCycleBulkChargePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleBulkUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleBulkUserError>(query);
            return this;
        }
    }
}