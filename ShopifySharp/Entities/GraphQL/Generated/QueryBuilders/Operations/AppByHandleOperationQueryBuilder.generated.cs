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
    public sealed class AppByHandleOperationQueryBuilder : FieldsQueryBuilderBase<App, AppByHandleOperationQueryBuilder>, IGraphOperationQueryBuilder<App>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AppByHandleArgumentsBuilder Arguments { get; }
        protected override AppByHandleOperationQueryBuilder Self => this;

        public AppByHandleOperationQueryBuilder() : this("appByHandle")
        {
        }

        public AppByHandleOperationQueryBuilder(string name) : base(new Query<App>(name))
        {
            Arguments = new AppByHandleArgumentsBuilder(base.InnerQuery);
        }

        public AppByHandleOperationQueryBuilder(IQuery<App> query) : base(query)
        {
            Arguments = new AppByHandleArgumentsBuilder(base.InnerQuery);
        }

        public AppByHandleOperationQueryBuilder ApiKey()
        {
            base.InnerQuery.AddField("apiKey");
            return this;
        }

        public AppByHandleOperationQueryBuilder AppStoreAppUrl()
        {
            base.InnerQuery.AddField("appStoreAppUrl");
            return this;
        }

        public AppByHandleOperationQueryBuilder AppStoreDeveloperUrl()
        {
            base.InnerQuery.AddField("appStoreDeveloperUrl");
            return this;
        }

        public AppByHandleOperationQueryBuilder AvailableAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("availableAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder Banner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public AppByHandleOperationQueryBuilder DeveloperName()
        {
            base.InnerQuery.AddField("developerName");
            return this;
        }

        public AppByHandleOperationQueryBuilder DeveloperType()
        {
            base.InnerQuery.AddField("developerType");
            return this;
        }

        [Obsolete("Use `appStoreDeveloperUrl` instead.")]
        public AppByHandleOperationQueryBuilder DeveloperUrl()
        {
            base.InnerQuery.AddField("developerUrl");
            return this;
        }

        public AppByHandleOperationQueryBuilder Embedded()
        {
            base.InnerQuery.AddField("embedded");
            return this;
        }

        public AppByHandleOperationQueryBuilder FailedRequirements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FailedRequirementQueryBuilder> build)
        {
            var query = new Query<FailedRequirement>("failedRequirements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FailedRequirementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FailedRequirement>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder Features()
        {
            base.InnerQuery.AddField("features");
            return this;
        }

        public AppByHandleOperationQueryBuilder Feedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public AppByHandleOperationQueryBuilder Icon(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppByHandleOperationQueryBuilder Installation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("installation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder InstallUrl()
        {
            base.InnerQuery.AddField("installUrl");
            return this;
        }

        public AppByHandleOperationQueryBuilder IsPostPurchaseAppInUse()
        {
            base.InnerQuery.AddField("isPostPurchaseAppInUse");
            return this;
        }

        [Obsolete("Use AppInstallation.launchUrl instead")]
        public AppByHandleOperationQueryBuilder LaunchUrl()
        {
            base.InnerQuery.AddField("launchUrl");
            return this;
        }

        public AppByHandleOperationQueryBuilder NavigationItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder OptionalAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("optionalAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder PreviouslyInstalled()
        {
            base.InnerQuery.AddField("previouslyInstalled");
            return this;
        }

        public AppByHandleOperationQueryBuilder PricingDetails()
        {
            base.InnerQuery.AddField("pricingDetails");
            return this;
        }

        public AppByHandleOperationQueryBuilder PricingDetailsSummary()
        {
            base.InnerQuery.AddField("pricingDetailsSummary");
            return this;
        }

        public AppByHandleOperationQueryBuilder PrivacyPolicyUrl()
        {
            base.InnerQuery.AddField("privacyPolicyUrl");
            return this;
        }

        public AppByHandleOperationQueryBuilder PublicCategory()
        {
            base.InnerQuery.AddField("publicCategory");
            return this;
        }

        public AppByHandleOperationQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }

        public AppByHandleOperationQueryBuilder RequestedAccessScopes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("requestedAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder Screenshots(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("screenshots");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AppByHandleOperationQueryBuilder ShopifyDeveloped()
        {
            base.InnerQuery.AddField("shopifyDeveloped");
            return this;
        }

        public AppByHandleOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public AppByHandleOperationQueryBuilder UninstallMessage()
        {
            base.InnerQuery.AddField("uninstallMessage");
            return this;
        }

        [Obsolete("Use AppInstallation.uninstallUrl instead")]
        public AppByHandleOperationQueryBuilder UninstallUrl()
        {
            base.InnerQuery.AddField("uninstallUrl");
            return this;
        }

        public AppByHandleOperationQueryBuilder WebhookApiVersion()
        {
            base.InnerQuery.AddField("webhookApiVersion");
            return this;
        }
    }
}