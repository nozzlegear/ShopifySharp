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
    public sealed class AppOperationQueryBuilder : FieldsQueryBuilderBase<App, AppOperationQueryBuilder>, IGraphOperationQueryBuilder<App>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AppArgumentsBuilder Arguments { get; }
        protected override AppOperationQueryBuilder Self => this;

        public AppOperationQueryBuilder() : this("app")
        {
        }

        public AppOperationQueryBuilder(string name) : base(new Query<App>(name))
        {
            Arguments = new AppArgumentsBuilder(base.InnerQuery);
        }

        public AppOperationQueryBuilder(IQuery<App> query) : base(query)
        {
            Arguments = new AppArgumentsBuilder(base.InnerQuery);
        }

        public AppOperationQueryBuilder ApiKey()
        {
            base.InnerQuery.AddField("apiKey");
            return this;
        }

        public AppOperationQueryBuilder AppStoreAppUrl()
        {
            base.InnerQuery.AddField("appStoreAppUrl");
            return this;
        }

        public AppOperationQueryBuilder AppStoreDeveloperUrl()
        {
            base.InnerQuery.AddField("appStoreDeveloperUrl");
            return this;
        }

        public AppOperationQueryBuilder AvailableAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("availableAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppOperationQueryBuilder Banner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public AppOperationQueryBuilder DeveloperName()
        {
            base.InnerQuery.AddField("developerName");
            return this;
        }

        public AppOperationQueryBuilder DeveloperType()
        {
            base.InnerQuery.AddField("developerType");
            return this;
        }

        [Obsolete("Use `appStoreDeveloperUrl` instead.")]
        public AppOperationQueryBuilder DeveloperUrl()
        {
            base.InnerQuery.AddField("developerUrl");
            return this;
        }

        public AppOperationQueryBuilder Embedded()
        {
            base.InnerQuery.AddField("embedded");
            return this;
        }

        public AppOperationQueryBuilder FailedRequirements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FailedRequirementQueryBuilder> build)
        {
            var query = new Query<FailedRequirement>("failedRequirements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FailedRequirementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FailedRequirement>(query);
            return this;
        }

        public AppOperationQueryBuilder Features()
        {
            base.InnerQuery.AddField("features");
            return this;
        }

        public AppOperationQueryBuilder Feedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public AppOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public AppOperationQueryBuilder Icon(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppOperationQueryBuilder Installation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("installation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public AppOperationQueryBuilder InstallUrl()
        {
            base.InnerQuery.AddField("installUrl");
            return this;
        }

        public AppOperationQueryBuilder IsPostPurchaseAppInUse()
        {
            base.InnerQuery.AddField("isPostPurchaseAppInUse");
            return this;
        }

        [Obsolete("Use AppInstallation.launchUrl instead")]
        public AppOperationQueryBuilder LaunchUrl()
        {
            base.InnerQuery.AddField("launchUrl");
            return this;
        }

        public AppOperationQueryBuilder NavigationItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public AppOperationQueryBuilder OptionalAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("optionalAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppOperationQueryBuilder PreviouslyInstalled()
        {
            base.InnerQuery.AddField("previouslyInstalled");
            return this;
        }

        public AppOperationQueryBuilder PricingDetails()
        {
            base.InnerQuery.AddField("pricingDetails");
            return this;
        }

        public AppOperationQueryBuilder PricingDetailsSummary()
        {
            base.InnerQuery.AddField("pricingDetailsSummary");
            return this;
        }

        public AppOperationQueryBuilder PrivacyPolicyUrl()
        {
            base.InnerQuery.AddField("privacyPolicyUrl");
            return this;
        }

        public AppOperationQueryBuilder PublicCategory()
        {
            base.InnerQuery.AddField("publicCategory");
            return this;
        }

        public AppOperationQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }

        public AppOperationQueryBuilder RequestedAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("requestedAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppOperationQueryBuilder Screenshots(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("screenshots");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppOperationQueryBuilder ShopifyDeveloped()
        {
            base.InnerQuery.AddField("shopifyDeveloped");
            return this;
        }

        public AppOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public AppOperationQueryBuilder UninstallMessage()
        {
            base.InnerQuery.AddField("uninstallMessage");
            return this;
        }

        [Obsolete("Use AppInstallation.uninstallUrl instead")]
        public AppOperationQueryBuilder UninstallUrl()
        {
            base.InnerQuery.AddField("uninstallUrl");
            return this;
        }

        public AppOperationQueryBuilder WebhookApiVersion()
        {
            base.InnerQuery.AddField("webhookApiVersion");
            return this;
        }
    }
}