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
    public sealed class SubscriptionBillingCycleBillingAttemptsQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptConnection, SubscriptionBillingCycleBillingAttemptsQueryBuilder>, IHasArguments<SubscriptionBillingCycleBillingAttemptsArgumentsBuilder>
    {
        public SubscriptionBillingCycleBillingAttemptsArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleBillingAttemptsQueryBuilder Self => this;

        public SubscriptionBillingCycleBillingAttemptsQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptConnection>(name))
        {
            Arguments = new SubscriptionBillingCycleBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBillingAttemptsQueryBuilder(IQuery<SubscriptionBillingAttemptConnection> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBillingAttemptsQueryBuilder SetArguments(Action<SubscriptionBillingCycleBillingAttemptsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionBillingCycleBillingAttemptsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptEdge>(query);
            return this;
        }

        public SubscriptionBillingCycleBillingAttemptsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionBillingCycleBillingAttemptsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}