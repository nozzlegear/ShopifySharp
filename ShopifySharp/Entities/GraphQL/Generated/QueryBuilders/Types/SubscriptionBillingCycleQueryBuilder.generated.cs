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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class SubscriptionBillingCycleQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycle, SubscriptionBillingCycleQueryBuilder>
    {
        protected override SubscriptionBillingCycleQueryBuilder Self => this;

        public SubscriptionBillingCycleQueryBuilder() : this("subscriptionBillingCycle")
        {
        }

        public SubscriptionBillingCycleQueryBuilder(string name) : base(new Query<SubscriptionBillingCycle>(name))
        {
        }

        public SubscriptionBillingCycleQueryBuilder(IQuery<SubscriptionBillingCycle> query) : base(query)
        {
        }

        public SubscriptionBillingCycleQueryBuilder BillingAttemptExpectedDate()
        {
            base.InnerQuery.AddField("billingAttemptExpectedDate");
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder BillingAttempts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptConnection>("billingAttempts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptConnection>(query);
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder CycleEndAt()
        {
            base.InnerQuery.AddField("cycleEndAt");
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder CycleIndex()
        {
            base.InnerQuery.AddField("cycleIndex");
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder CycleStartAt()
        {
            base.InnerQuery.AddField("cycleStartAt");
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder EditedContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEditedContract>("editedContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEditedContract>(query);
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder Skipped()
        {
            base.InnerQuery.AddField("skipped");
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder SourceContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("sourceContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionBillingCycleQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}