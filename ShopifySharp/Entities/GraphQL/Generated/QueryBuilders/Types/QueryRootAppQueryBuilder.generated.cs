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
    public sealed class QueryRootAppQueryBuilder : FieldsQueryBuilderBase<App, QueryRootAppQueryBuilder>, IHasArguments<QueryRootAppArgumentsBuilder>
    {
        public QueryRootAppArgumentsBuilder Arguments { get; }
        protected override QueryRootAppQueryBuilder Self => this;

        public QueryRootAppQueryBuilder(string name) : base(new Query<App>(name))
        {
            Arguments = new QueryRootAppArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAppQueryBuilder(IQuery<App> query) : base(query)
        {
            Arguments = new QueryRootAppArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAppQueryBuilder SetArguments(Action<QueryRootAppArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAppQueryBuilder ApiKey()
        {
            base.InnerQuery.AddField("apiKey");
            return this;
        }

        public QueryRootAppQueryBuilder AppStoreAppUrl()
        {
            base.InnerQuery.AddField("appStoreAppUrl");
            return this;
        }

        public QueryRootAppQueryBuilder AppStoreDeveloperUrl()
        {
            base.InnerQuery.AddField("appStoreDeveloperUrl");
            return this;
        }

        public QueryRootAppQueryBuilder AvailableAccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("availableAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public QueryRootAppQueryBuilder Banner(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootAppQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public QueryRootAppQueryBuilder DeveloperName()
        {
            base.InnerQuery.AddField("developerName");
            return this;
        }

        public QueryRootAppQueryBuilder DeveloperType()
        {
            base.InnerQuery.AddField("developerType");
            return this;
        }

        [Obsolete("Use `appStoreDeveloperUrl` instead.")]
        public QueryRootAppQueryBuilder DeveloperUrl()
        {
            base.InnerQuery.AddField("developerUrl");
            return this;
        }

        public QueryRootAppQueryBuilder Embedded()
        {
            base.InnerQuery.AddField("embedded");
            return this;
        }

        public QueryRootAppQueryBuilder FailedRequirements(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FailedRequirementQueryBuilder> build)
        {
            var query = new Query<FailedRequirement>("failedRequirements");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FailedRequirementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FailedRequirement>(query);
            return this;
        }

        public QueryRootAppQueryBuilder Features()
        {
            base.InnerQuery.AddField("features");
            return this;
        }

        public QueryRootAppQueryBuilder Feedback(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public QueryRootAppQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootAppQueryBuilder Icon(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootAppQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootAppQueryBuilder Installation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("installation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppInstallation>(query);
            return this;
        }

        public QueryRootAppQueryBuilder InstallUrl()
        {
            base.InnerQuery.AddField("installUrl");
            return this;
        }

        public QueryRootAppQueryBuilder IsPostPurchaseAppInUse()
        {
            base.InnerQuery.AddField("isPostPurchaseAppInUse");
            return this;
        }

        [Obsolete("Use AppInstallation.launchUrl instead")]
        public QueryRootAppQueryBuilder LaunchUrl()
        {
            base.InnerQuery.AddField("launchUrl");
            return this;
        }

        public QueryRootAppQueryBuilder NavigationItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public QueryRootAppQueryBuilder OptionalAccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("optionalAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public QueryRootAppQueryBuilder PreviouslyInstalled()
        {
            base.InnerQuery.AddField("previouslyInstalled");
            return this;
        }

        public QueryRootAppQueryBuilder PricingDetails()
        {
            base.InnerQuery.AddField("pricingDetails");
            return this;
        }

        public QueryRootAppQueryBuilder PricingDetailsSummary()
        {
            base.InnerQuery.AddField("pricingDetailsSummary");
            return this;
        }

        public QueryRootAppQueryBuilder PrivacyPolicyUrl()
        {
            base.InnerQuery.AddField("privacyPolicyUrl");
            return this;
        }

        public QueryRootAppQueryBuilder PublicCategory()
        {
            base.InnerQuery.AddField("publicCategory");
            return this;
        }

        public QueryRootAppQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }

        public QueryRootAppQueryBuilder RequestedAccessScopes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("requestedAccessScopes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public QueryRootAppQueryBuilder Screenshots(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("screenshots");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootAppQueryBuilder ShopifyDeveloped()
        {
            base.InnerQuery.AddField("shopifyDeveloped");
            return this;
        }

        public QueryRootAppQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootAppQueryBuilder UninstallMessage()
        {
            base.InnerQuery.AddField("uninstallMessage");
            return this;
        }

        [Obsolete("Use AppInstallation.uninstallUrl instead")]
        public QueryRootAppQueryBuilder UninstallUrl()
        {
            base.InnerQuery.AddField("uninstallUrl");
            return this;
        }

        public QueryRootAppQueryBuilder WebhookApiVersion()
        {
            base.InnerQuery.AddField("webhookApiVersion");
            return this;
        }
    }
}