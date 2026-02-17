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
    public sealed class SubscriptionBillingCycleChargeOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleChargePayload, SubscriptionBillingCycleChargeOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleChargePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleChargeArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleChargeOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleChargeOperationQueryBuilder() : this("subscriptionBillingCycleCharge")
        {
        }

        public SubscriptionBillingCycleChargeOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleChargePayload>(name))
        {
            Arguments = new SubscriptionBillingCycleChargeArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleChargeOperationQueryBuilder(IQuery<SubscriptionBillingCycleChargePayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleChargeArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleChargeOperationQueryBuilder SubscriptionBillingAttempt(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("subscriptionBillingAttempt");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionBillingCycleChargeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BillingAttemptUserErrorQueryBuilder> build)
        {
            var query = new Query<BillingAttemptUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BillingAttemptUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BillingAttemptUserError>(query);
            return this;
        }
    }
}