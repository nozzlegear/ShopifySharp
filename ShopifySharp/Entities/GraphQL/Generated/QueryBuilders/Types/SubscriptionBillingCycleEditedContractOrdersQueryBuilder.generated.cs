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
    public sealed class SubscriptionBillingCycleEditedContractOrdersQueryBuilder : FieldsQueryBuilderBase<OrderConnection, SubscriptionBillingCycleEditedContractOrdersQueryBuilder>, IHasArguments<SubscriptionBillingCycleEditedContractOrdersArgumentsBuilder>
    {
        public SubscriptionBillingCycleEditedContractOrdersArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleEditedContractOrdersQueryBuilder Self => this;

        public SubscriptionBillingCycleEditedContractOrdersQueryBuilder(string name) : base(new Query<OrderConnection>(name))
        {
            Arguments = new SubscriptionBillingCycleEditedContractOrdersArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleEditedContractOrdersQueryBuilder(IQuery<OrderConnection> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleEditedContractOrdersArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleEditedContractOrdersQueryBuilder SetArguments(Action<SubscriptionBillingCycleEditedContractOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionBillingCycleEditedContractOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEdgeQueryBuilder> build)
        {
            var query = new Query<OrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEdge>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public SubscriptionBillingCycleEditedContractOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}