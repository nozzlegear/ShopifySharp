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
    public sealed class SubscriptionBillingCycleSkipOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleSkipPayload, SubscriptionBillingCycleSkipOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleSkipPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleSkipArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleSkipOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleSkipOperationQueryBuilder() : this("subscriptionBillingCycleSkip")
        {
        }

        public SubscriptionBillingCycleSkipOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleSkipPayload>(name))
        {
            Arguments = new SubscriptionBillingCycleSkipArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleSkipOperationQueryBuilder(IQuery<SubscriptionBillingCycleSkipPayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleSkipArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleSkipOperationQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleSkipOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleSkipUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleSkipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleSkipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleSkipUserError>(query);
            return this;
        }
    }
}