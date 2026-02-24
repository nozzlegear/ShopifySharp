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
    public sealed class SubscriptionContractBillingAttemptsQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptConnection, SubscriptionContractBillingAttemptsQueryBuilder>, IHasArguments<SubscriptionContractBillingAttemptsArgumentsBuilder>
    {
        public SubscriptionContractBillingAttemptsArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractBillingAttemptsQueryBuilder Self => this;

        public SubscriptionContractBillingAttemptsQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptConnection>(name))
        {
            Arguments = new SubscriptionContractBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractBillingAttemptsQueryBuilder(IQuery<SubscriptionBillingAttemptConnection> query) : base(query)
        {
            Arguments = new SubscriptionContractBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractBillingAttemptsQueryBuilder SetArguments(Action<SubscriptionContractBillingAttemptsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionContractBillingAttemptsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptEdge>(query);
            return this;
        }

        public SubscriptionContractBillingAttemptsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionContractBillingAttemptsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}