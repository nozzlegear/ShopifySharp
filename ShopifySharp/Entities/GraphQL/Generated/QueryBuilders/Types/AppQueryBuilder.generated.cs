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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class AppQueryBuilder : FieldsQueryBuilderBase<App, AppQueryBuilder>
    {
        protected override AppQueryBuilder Self => this;

        public AppQueryBuilder() : this("app")
        {
        }

        public AppQueryBuilder(string name) : base(new Query<App>(name))
        {
        }

        public AppQueryBuilder(IQuery<App> query) : base(query)
        {
        }

        public AppQueryBuilder ApiKey()
        {
            base.InnerQuery.AddField("apiKey");
            return this;
        }

        public AppQueryBuilder AppStoreAppUrl()
        {
            base.InnerQuery.AddField("appStoreAppUrl");
            return this;
        }

        public AppQueryBuilder AppStoreDeveloperUrl()
        {
            base.InnerQuery.AddField("appStoreDeveloperUrl");
            return this;
        }

        public AppQueryBuilder AvailableAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("availableAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppQueryBuilder Banner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public AppQueryBuilder DeveloperName()
        {
            base.InnerQuery.AddField("developerName");
            return this;
        }

        public AppQueryBuilder DeveloperType()
        {
            base.InnerQuery.AddField("developerType");
            return this;
        }

        [Obsolete("Use `appStoreDeveloperUrl` instead.")]
        public AppQueryBuilder DeveloperUrl()
        {
            base.InnerQuery.AddField("developerUrl");
            return this;
        }

        public AppQueryBuilder Embedded()
        {
            base.InnerQuery.AddField("embedded");
            return this;
        }

        public AppQueryBuilder FailedRequirements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FailedRequirementQueryBuilder> build)
        {
            var query = new Query<FailedRequirement>("failedRequirements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FailedRequirementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FailedRequirement>(query);
            return this;
        }

        public AppQueryBuilder Features()
        {
            base.InnerQuery.AddField("features");
            return this;
        }

        public AppQueryBuilder Feedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public AppQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public AppQueryBuilder Icon(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppQueryBuilder Installation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("installation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public AppQueryBuilder InstallUrl()
        {
            base.InnerQuery.AddField("installUrl");
            return this;
        }

        public AppQueryBuilder IsPostPurchaseAppInUse()
        {
            base.InnerQuery.AddField("isPostPurchaseAppInUse");
            return this;
        }

        [Obsolete("Use AppInstallation.launchUrl instead")]
        public AppQueryBuilder LaunchUrl()
        {
            base.InnerQuery.AddField("launchUrl");
            return this;
        }

        public AppQueryBuilder NavigationItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public AppQueryBuilder OptionalAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("optionalAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppQueryBuilder PreviouslyInstalled()
        {
            base.InnerQuery.AddField("previouslyInstalled");
            return this;
        }

        public AppQueryBuilder PricingDetails()
        {
            base.InnerQuery.AddField("pricingDetails");
            return this;
        }

        public AppQueryBuilder PricingDetailsSummary()
        {
            base.InnerQuery.AddField("pricingDetailsSummary");
            return this;
        }

        public AppQueryBuilder PrivacyPolicyUrl()
        {
            base.InnerQuery.AddField("privacyPolicyUrl");
            return this;
        }

        public AppQueryBuilder PublicCategory()
        {
            base.InnerQuery.AddField("publicCategory");
            return this;
        }

        public AppQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }

        public AppQueryBuilder RequestedAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("requestedAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppQueryBuilder Screenshots(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("screenshots");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppQueryBuilder ShopifyDeveloped()
        {
            base.InnerQuery.AddField("shopifyDeveloped");
            return this;
        }

        public AppQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public AppQueryBuilder UninstallMessage()
        {
            base.InnerQuery.AddField("uninstallMessage");
            return this;
        }

        [Obsolete("Use AppInstallation.uninstallUrl instead")]
        public AppQueryBuilder UninstallUrl()
        {
            base.InnerQuery.AddField("uninstallUrl");
            return this;
        }

        public AppQueryBuilder WebhookApiVersion()
        {
            base.InnerQuery.AddField("webhookApiVersion");
            return this;
        }
    }
}