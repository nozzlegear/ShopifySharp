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
    public sealed class AppInstallationOperationQueryBuilder : FieldsQueryBuilderBase<AppInstallation, AppInstallationOperationQueryBuilder>, IGraphOperationQueryBuilder<AppInstallation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AppInstallationArgumentsBuilder Arguments { get; }
        protected override AppInstallationOperationQueryBuilder Self => this;

        public AppInstallationOperationQueryBuilder() : this("appInstallation")
        {
        }

        public AppInstallationOperationQueryBuilder(string name) : base(new Query<AppInstallation>(name))
        {
            Arguments = new AppInstallationArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationOperationQueryBuilder(IQuery<AppInstallation> query) : base(query)
        {
            Arguments = new AppInstallationArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationOperationQueryBuilder AccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("accessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder ActiveSubscriptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("activeSubscriptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder AllSubscriptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionConnectionQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionConnection>("allSubscriptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionConnection>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder Channel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder Credits(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditConnectionQueryBuilder> build)
        {
            var query = new Query<AppCreditConnection>("credits");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppCreditConnection>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppInstallationOperationQueryBuilder LaunchUrl()
        {
            base.InnerQuery.AddField("launchUrl");
            return this;
        }

        public AppInstallationOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder OneTimePurchases(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppPurchaseOneTimeConnectionQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTimeConnection>("oneTimePurchases");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppPurchaseOneTimeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTimeConnection>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder RevenueAttributionRecords(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordConnectionQueryBuilder> build)
        {
            var query = new Query<AppRevenueAttributionRecordConnection>("revenueAttributionRecords");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevenueAttributionRecordConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevenueAttributionRecordConnection>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder Subscriptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("subscriptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppInstallationOperationQueryBuilder UninstallUrl()
        {
            base.InnerQuery.AddField("uninstallUrl");
            return this;
        }
    }
}