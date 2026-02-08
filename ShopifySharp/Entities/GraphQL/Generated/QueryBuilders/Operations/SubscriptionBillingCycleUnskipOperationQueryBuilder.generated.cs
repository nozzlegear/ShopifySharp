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
    public sealed class SubscriptionBillingCycleUnskipOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleUnskipPayload, SubscriptionBillingCycleUnskipOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleUnskipPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleUnskipArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleUnskipOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleUnskipOperationQueryBuilder() : this("subscriptionBillingCycleUnskip")
        {
        }

        public SubscriptionBillingCycleUnskipOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleUnskipPayload>(name))
        {
            Arguments = new SubscriptionBillingCycleUnskipArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleUnskipOperationQueryBuilder(IQuery<SubscriptionBillingCycleUnskipPayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleUnskipArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleUnskipOperationQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleUnskipOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUnskipUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUnskipUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUnskipUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUnskipUserError>(query);
            return this;
        }
    }
}