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
    public sealed class QueryRootSubscriptionBillingAttemptsQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptConnection, QueryRootSubscriptionBillingAttemptsQueryBuilder>, IHasArguments<QueryRootSubscriptionBillingAttemptsArgumentsBuilder>
    {
        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder Arguments { get; }
        protected override QueryRootSubscriptionBillingAttemptsQueryBuilder Self => this;

        public QueryRootSubscriptionBillingAttemptsQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptConnection>(name))
        {
            Arguments = new QueryRootSubscriptionBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingAttemptsQueryBuilder(IQuery<SubscriptionBillingAttemptConnection> query) : base(query)
        {
            Arguments = new QueryRootSubscriptionBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingAttemptsQueryBuilder SetArguments(Action<QueryRootSubscriptionBillingAttemptsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptEdge>(query);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}