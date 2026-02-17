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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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

        public SubscriptionBillingCycleSkipOperationQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleSkipOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleSkipUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleSkipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleSkipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleSkipUserError>(query);
            return this;
        }
    }
}