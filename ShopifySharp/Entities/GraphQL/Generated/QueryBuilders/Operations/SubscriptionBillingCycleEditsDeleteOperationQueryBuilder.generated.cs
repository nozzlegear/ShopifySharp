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
    public sealed class SubscriptionBillingCycleEditsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleEditsDeletePayload, SubscriptionBillingCycleEditsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleEditsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleEditsDeleteArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleEditsDeleteOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleEditsDeleteOperationQueryBuilder() : this("subscriptionBillingCycleEditsDelete")
        {
        }

        public SubscriptionBillingCycleEditsDeleteOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleEditsDeletePayload>(name))
        {
            Arguments = new SubscriptionBillingCycleEditsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleEditsDeleteOperationQueryBuilder(IQuery<SubscriptionBillingCycleEditsDeletePayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleEditsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleEditsDeleteOperationQueryBuilder BillingCycles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleEditsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUserError>(query);
            return this;
        }
    }
}