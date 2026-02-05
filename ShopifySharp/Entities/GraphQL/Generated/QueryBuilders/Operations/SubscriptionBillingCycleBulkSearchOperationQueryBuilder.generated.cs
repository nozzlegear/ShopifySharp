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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SubscriptionBillingCycleBulkSearchOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleBulkSearchPayload, SubscriptionBillingCycleBulkSearchOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleBulkSearchPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleBulkSearchArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleBulkSearchOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleBulkSearchOperationQueryBuilder() : this("subscriptionBillingCycleBulkSearch")
        {
        }

        public SubscriptionBillingCycleBulkSearchOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleBulkSearchPayload>(name))
        {
            Arguments = new SubscriptionBillingCycleBulkSearchArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBulkSearchOperationQueryBuilder(IQuery<SubscriptionBillingCycleBulkSearchPayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleBulkSearchArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBulkSearchOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public SubscriptionBillingCycleBulkSearchOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleBulkUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleBulkUserError>(query);
            return this;
        }
    }
}