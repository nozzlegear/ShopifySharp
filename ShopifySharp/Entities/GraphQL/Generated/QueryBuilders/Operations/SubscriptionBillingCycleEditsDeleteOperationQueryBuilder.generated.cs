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

        public SubscriptionBillingCycleEditsDeleteOperationQueryBuilder BillingCycles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("billingCycles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleEditsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleUserError>(query);
            return this;
        }
    }
}