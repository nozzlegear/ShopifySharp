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
    public sealed class AppInstallationQueryBuilder : FieldsQueryBuilderBase<AppInstallation, AppInstallationQueryBuilder>
    {
        protected override AppInstallationQueryBuilder Self => this;

        public AppInstallationQueryBuilder() : this("appInstallation")
        {
        }

        public AppInstallationQueryBuilder(string name) : base(new Query<AppInstallation>(name))
        {
        }

        public AppInstallationQueryBuilder(IQuery<AppInstallation> query) : base(query)
        {
        }

        public AppInstallationQueryBuilder AccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("accessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppInstallationQueryBuilder ActiveSubscriptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("activeSubscriptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppInstallationQueryBuilder AllSubscriptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionConnectionQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionConnection>("allSubscriptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionConnection>(query);
            return this;
        }

        public AppInstallationQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppInstallationQueryBuilder Channel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public AppInstallationQueryBuilder Credits(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditConnectionQueryBuilder> build)
        {
            var query = new Query<AppCreditConnection>("credits");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppCreditConnection>(query);
            return this;
        }

        public AppInstallationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppInstallationQueryBuilder LaunchUrl()
        {
            base.InnerQuery.AddField("launchUrl");
            return this;
        }

        public AppInstallationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public AppInstallationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public AppInstallationQueryBuilder OneTimePurchases(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeConnectionQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTimeConnection>("oneTimePurchases");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTimeConnection>(query);
            return this;
        }

        public AppInstallationQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public AppInstallationQueryBuilder RevenueAttributionRecords(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordConnectionQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecordConnection>("revenueAttributionRecords");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppRevenueAttributionRecordConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecordConnection>(query);
            return this;
        }

        public AppInstallationQueryBuilder Subscriptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("subscriptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppInstallationQueryBuilder UninstallUrl()
        {
            base.InnerQuery.AddField("uninstallUrl");
            return this;
        }
    }
}