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
    public sealed class QueryRootSubscriptionBillingCycleQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycle, QueryRootSubscriptionBillingCycleQueryBuilder>, IHasArguments<QueryRootSubscriptionBillingCycleArgumentsBuilder>
    {
        public QueryRootSubscriptionBillingCycleArgumentsBuilder Arguments { get; }
        protected override QueryRootSubscriptionBillingCycleQueryBuilder Self => this;

        public QueryRootSubscriptionBillingCycleQueryBuilder(string name) : base(new Query<SubscriptionBillingCycle>(name))
        {
            Arguments = new QueryRootSubscriptionBillingCycleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder(IQuery<SubscriptionBillingCycle> query) : base(query)
        {
            Arguments = new QueryRootSubscriptionBillingCycleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder SetArguments(Action<QueryRootSubscriptionBillingCycleArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder BillingAttemptExpectedDate()
        {
            base.InnerQuery.AddField("billingAttemptExpectedDate");
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder BillingAttempts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptConnection>("billingAttempts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptConnection>(query);
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder CycleEndAt()
        {
            base.InnerQuery.AddField("cycleEndAt");
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder CycleIndex()
        {
            base.InnerQuery.AddField("cycleIndex");
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder CycleStartAt()
        {
            base.InnerQuery.AddField("cycleStartAt");
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder EditedContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEditedContract>("editedContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEditedContract>(query);
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder Skipped()
        {
            base.InnerQuery.AddField("skipped");
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder SourceContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("sourceContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public QueryRootSubscriptionBillingCycleQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}