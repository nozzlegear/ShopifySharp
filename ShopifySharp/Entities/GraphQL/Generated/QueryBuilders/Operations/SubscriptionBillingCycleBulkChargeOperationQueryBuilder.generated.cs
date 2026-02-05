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
    public sealed class SubscriptionBillingCycleBulkChargeOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleBulkChargePayload, SubscriptionBillingCycleBulkChargeOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleBulkChargePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleBulkChargeArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleBulkChargeOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleBulkChargeOperationQueryBuilder() : this("subscriptionBillingCycleBulkCharge")
        {
        }

        public SubscriptionBillingCycleBulkChargeOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleBulkChargePayload>(name))
        {
            Arguments = new SubscriptionBillingCycleBulkChargeArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBulkChargeOperationQueryBuilder(IQuery<SubscriptionBillingCycleBulkChargePayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleBulkChargeArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBulkChargeOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public SubscriptionBillingCycleBulkChargeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleBulkUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleBulkUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleBulkUserError>(query);
            return this;
        }
    }
}