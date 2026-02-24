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
    public sealed class AppInstallationAllSubscriptionsQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionConnection, AppInstallationAllSubscriptionsQueryBuilder>, IHasArguments<AppInstallationAllSubscriptionsArgumentsBuilder>
    {
        public AppInstallationAllSubscriptionsArgumentsBuilder Arguments { get; }
        protected override AppInstallationAllSubscriptionsQueryBuilder Self => this;

        public AppInstallationAllSubscriptionsQueryBuilder(string name) : base(new Query<AppSubscriptionConnection>(name))
        {
            Arguments = new AppInstallationAllSubscriptionsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationAllSubscriptionsQueryBuilder(IQuery<AppSubscriptionConnection> query) : base(query)
        {
            Arguments = new AppInstallationAllSubscriptionsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationAllSubscriptionsQueryBuilder SetArguments(Action<AppInstallationAllSubscriptionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AppInstallationAllSubscriptionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionEdgeQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionEdge>(query);
            return this;
        }

        public AppInstallationAllSubscriptionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppInstallationAllSubscriptionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}