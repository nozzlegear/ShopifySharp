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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class AppByKeyOperationQueryBuilder : FieldsQueryBuilderBase<App, AppByKeyOperationQueryBuilder>, IGraphOperationQueryBuilder<App>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AppByKeyArgumentsBuilder Arguments { get; }
        protected override AppByKeyOperationQueryBuilder Self => this;

        public AppByKeyOperationQueryBuilder() : this("appByKey")
        {
        }

        public AppByKeyOperationQueryBuilder(string name) : base(new Query<App>(name))
        {
            Arguments = new AppByKeyArgumentsBuilder(base.InnerQuery);
        }

        public AppByKeyOperationQueryBuilder(IQuery<App> query) : base(query)
        {
            Arguments = new AppByKeyArgumentsBuilder(base.InnerQuery);
        }

        public AppByKeyOperationQueryBuilder ApiKey()
        {
            base.InnerQuery.AddField("apiKey");
            return this;
        }

        public AppByKeyOperationQueryBuilder AppStoreAppUrl()
        {
            base.InnerQuery.AddField("appStoreAppUrl");
            return this;
        }

        public AppByKeyOperationQueryBuilder AppStoreDeveloperUrl()
        {
            base.InnerQuery.AddField("appStoreDeveloperUrl");
            return this;
        }

        public AppByKeyOperationQueryBuilder AvailableAccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("availableAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder Banner(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public AppByKeyOperationQueryBuilder DeveloperName()
        {
            base.InnerQuery.AddField("developerName");
            return this;
        }

        public AppByKeyOperationQueryBuilder DeveloperType()
        {
            base.InnerQuery.AddField("developerType");
            return this;
        }

        [Obsolete("Use `appStoreDeveloperUrl` instead.")]
        public AppByKeyOperationQueryBuilder DeveloperUrl()
        {
            base.InnerQuery.AddField("developerUrl");
            return this;
        }

        public AppByKeyOperationQueryBuilder Embedded()
        {
            base.InnerQuery.AddField("embedded");
            return this;
        }

        public AppByKeyOperationQueryBuilder FailedRequirements(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FailedRequirementQueryBuilder> build)
        {
            var query = new Query<FailedRequirement>("failedRequirements");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FailedRequirementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FailedRequirement>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder Features()
        {
            base.InnerQuery.AddField("features");
            return this;
        }

        public AppByKeyOperationQueryBuilder Feedback(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public AppByKeyOperationQueryBuilder Icon(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppByKeyOperationQueryBuilder Installation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("installation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder InstallUrl()
        {
            base.InnerQuery.AddField("installUrl");
            return this;
        }

        public AppByKeyOperationQueryBuilder IsPostPurchaseAppInUse()
        {
            base.InnerQuery.AddField("isPostPurchaseAppInUse");
            return this;
        }

        [Obsolete("Use AppInstallation.launchUrl instead")]
        public AppByKeyOperationQueryBuilder LaunchUrl()
        {
            base.InnerQuery.AddField("launchUrl");
            return this;
        }

        public AppByKeyOperationQueryBuilder NavigationItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder OptionalAccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("optionalAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder PreviouslyInstalled()
        {
            base.InnerQuery.AddField("previouslyInstalled");
            return this;
        }

        public AppByKeyOperationQueryBuilder PricingDetails()
        {
            base.InnerQuery.AddField("pricingDetails");
            return this;
        }

        public AppByKeyOperationQueryBuilder PricingDetailsSummary()
        {
            base.InnerQuery.AddField("pricingDetailsSummary");
            return this;
        }

        public AppByKeyOperationQueryBuilder PrivacyPolicyUrl()
        {
            base.InnerQuery.AddField("privacyPolicyUrl");
            return this;
        }

        public AppByKeyOperationQueryBuilder PublicCategory()
        {
            base.InnerQuery.AddField("publicCategory");
            return this;
        }

        public AppByKeyOperationQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }

        public AppByKeyOperationQueryBuilder RequestedAccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("requestedAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder Screenshots(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("screenshots");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppByKeyOperationQueryBuilder ShopifyDeveloped()
        {
            base.InnerQuery.AddField("shopifyDeveloped");
            return this;
        }

        public AppByKeyOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public AppByKeyOperationQueryBuilder UninstallMessage()
        {
            base.InnerQuery.AddField("uninstallMessage");
            return this;
        }

        [Obsolete("Use AppInstallation.uninstallUrl instead")]
        public AppByKeyOperationQueryBuilder UninstallUrl()
        {
            base.InnerQuery.AddField("uninstallUrl");
            return this;
        }

        public AppByKeyOperationQueryBuilder WebhookApiVersion()
        {
            base.InnerQuery.AddField("webhookApiVersion");
            return this;
        }
    }
}