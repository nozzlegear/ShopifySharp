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
    public sealed class SubscriptionBillingCycleBulkSearchPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleBulkSearchPayload, SubscriptionBillingCycleBulkSearchPayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleBulkSearchPayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleBulkSearchPayloadQueryBuilder() : this("subscriptionBillingCycleBulkSearchPayload")
        {
        }

        public SubscriptionBillingCycleBulkSearchPayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleBulkSearchPayload>(name))
        {
        }

        public SubscriptionBillingCycleBulkSearchPayloadQueryBuilder(IQuery<SubscriptionBillingCycleBulkSearchPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleBulkSearchPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public SubscriptionBillingCycleBulkSearchPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleBulkUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleBulkUserError>(query);
            return this;
        }
    }
}