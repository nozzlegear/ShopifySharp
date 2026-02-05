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
    public sealed class SubscriptionBillingCycleOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycle, SubscriptionBillingCycleOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycle>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SubscriptionBillingCycleArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleOperationQueryBuilder() : this("subscriptionBillingCycle")
        {
        }

        public SubscriptionBillingCycleOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycle>(name))
        {
            Arguments = new SubscriptionBillingCycleArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleOperationQueryBuilder(IQuery<SubscriptionBillingCycle> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleOperationQueryBuilder BillingAttemptExpectedDate()
        {
            base.InnerQuery.AddField("billingAttemptExpectedDate");
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder BillingAttempts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptConnection>("billingAttempts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptConnection>(query);
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder CycleEndAt()
        {
            base.InnerQuery.AddField("cycleEndAt");
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder CycleIndex()
        {
            base.InnerQuery.AddField("cycleIndex");
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder CycleStartAt()
        {
            base.InnerQuery.AddField("cycleStartAt");
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder EditedContract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEditedContract>("editedContract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEditedContract>(query);
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder Skipped()
        {
            base.InnerQuery.AddField("skipped");
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder SourceContract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("sourceContract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionBillingCycleOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}