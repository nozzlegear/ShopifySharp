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
    public sealed class QueryRootSubscriptionBillingCyclesQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleConnection, QueryRootSubscriptionBillingCyclesQueryBuilder>, IHasArguments<QueryRootSubscriptionBillingCyclesArgumentsBuilder>
    {
        public QueryRootSubscriptionBillingCyclesArgumentsBuilder Arguments { get; }
        protected override QueryRootSubscriptionBillingCyclesQueryBuilder Self => this;

        public QueryRootSubscriptionBillingCyclesQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleConnection>(name))
        {
            Arguments = new QueryRootSubscriptionBillingCyclesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingCyclesQueryBuilder(IQuery<SubscriptionBillingCycleConnection> query) : base(query)
        {
            Arguments = new QueryRootSubscriptionBillingCyclesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingCyclesQueryBuilder SetArguments(Action<QueryRootSubscriptionBillingCyclesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEdge>(query);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}