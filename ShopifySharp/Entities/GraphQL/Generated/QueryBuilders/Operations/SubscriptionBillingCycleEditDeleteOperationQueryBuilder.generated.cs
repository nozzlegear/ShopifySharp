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
    public sealed class SubscriptionBillingCycleEditDeleteOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleEditDeletePayload, SubscriptionBillingCycleEditDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleEditDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleEditDeleteArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleEditDeleteOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleEditDeleteOperationQueryBuilder() : this("subscriptionBillingCycleEditDelete")
        {
        }

        public SubscriptionBillingCycleEditDeleteOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleEditDeletePayload>(name))
        {
            Arguments = new SubscriptionBillingCycleEditDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleEditDeleteOperationQueryBuilder(IQuery<SubscriptionBillingCycleEditDeletePayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleEditDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleEditDeleteOperationQueryBuilder BillingCycles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleEditDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUserError>(query);
            return this;
        }
    }
}