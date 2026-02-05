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
    public sealed class SubscriptionBillingCycleScheduleEditOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleScheduleEditPayload, SubscriptionBillingCycleScheduleEditOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleScheduleEditPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleScheduleEditArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleScheduleEditOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleScheduleEditOperationQueryBuilder() : this("subscriptionBillingCycleScheduleEdit")
        {
        }

        public SubscriptionBillingCycleScheduleEditOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleScheduleEditPayload>(name))
        {
            Arguments = new SubscriptionBillingCycleScheduleEditArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleScheduleEditOperationQueryBuilder(IQuery<SubscriptionBillingCycleScheduleEditPayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleScheduleEditArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleScheduleEditOperationQueryBuilder BillingCycle(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycle");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleScheduleEditOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUserError>(query);
            return this;
        }
    }
}