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
    public sealed class MarketingActivityQueryBuilder : FieldsQueryBuilderBase<MarketingActivity, MarketingActivityQueryBuilder>
    {
        protected override MarketingActivityQueryBuilder Self => this;

        public MarketingActivityQueryBuilder() : this("marketingActivity")
        {
        }

        public MarketingActivityQueryBuilder(string name) : base(new Query<MarketingActivity>(name))
        {
        }

        public MarketingActivityQueryBuilder(IQuery<MarketingActivity> query) : base(query)
        {
        }

        public MarketingActivityQueryBuilder ActivityListUrl()
        {
            base.InnerQuery.AddField("activityListUrl");
            return this;
        }

        public MarketingActivityQueryBuilder AdSpend(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("adSpend");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MarketingActivityQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MarketingActivityQueryBuilder AppErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityExtensionAppErrorsQueryBuilder> build)
        {
            var query = new Query<MarketingActivityExtensionAppErrors>("appErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityExtensionAppErrorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityExtensionAppErrors>(query);
            return this;
        }

        public MarketingActivityQueryBuilder Budget(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingBudgetQueryBuilder> build)
        {
            var query = new Query<MarketingBudget>("budget");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingBudgetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingBudget>(query);
            return this;
        }

        public MarketingActivityQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MarketingActivityQueryBuilder FormData()
        {
            base.InnerQuery.AddField("formData");
            return this;
        }

        public MarketingActivityQueryBuilder HierarchyLevel()
        {
            base.InnerQuery.AddField("hierarchyLevel");
            return this;
        }

        public MarketingActivityQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketingActivityQueryBuilder InMainWorkflowVersion()
        {
            base.InnerQuery.AddField("inMainWorkflowVersion");
            return this;
        }

        public MarketingActivityQueryBuilder IsExternal()
        {
            base.InnerQuery.AddField("isExternal");
            return this;
        }

        [Obsolete("Use `marketingChannelType` instead.")]
        public MarketingActivityQueryBuilder MarketingChannel()
        {
            base.InnerQuery.AddField("marketingChannel");
            return this;
        }

        public MarketingActivityQueryBuilder MarketingChannelType()
        {
            base.InnerQuery.AddField("marketingChannelType");
            return this;
        }

        public MarketingActivityQueryBuilder MarketingEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("marketingEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public MarketingActivityQueryBuilder ParentActivityId()
        {
            base.InnerQuery.AddField("parentActivityId");
            return this;
        }

        public MarketingActivityQueryBuilder ParentRemoteId()
        {
            base.InnerQuery.AddField("parentRemoteId");
            return this;
        }

        public MarketingActivityQueryBuilder SourceAndMedium()
        {
            base.InnerQuery.AddField("sourceAndMedium");
            return this;
        }

        public MarketingActivityQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `statusBadgeTypeV2` instead.")]
        public MarketingActivityQueryBuilder StatusBadgeType()
        {
            base.InnerQuery.AddField("statusBadgeType");
            return this;
        }

        public MarketingActivityQueryBuilder StatusBadgeTypeV2()
        {
            base.InnerQuery.AddField("statusBadgeTypeV2");
            return this;
        }

        public MarketingActivityQueryBuilder StatusLabel()
        {
            base.InnerQuery.AddField("statusLabel");
            return this;
        }

        public MarketingActivityQueryBuilder StatusTransitionedAt()
        {
            base.InnerQuery.AddField("statusTransitionedAt");
            return this;
        }

        public MarketingActivityQueryBuilder Tactic()
        {
            base.InnerQuery.AddField("tactic");
            return this;
        }

        public MarketingActivityQueryBuilder TargetStatus()
        {
            base.InnerQuery.AddField("targetStatus");
            return this;
        }

        public MarketingActivityQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public MarketingActivityQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MarketingActivityQueryBuilder UrlParameterValue()
        {
            base.InnerQuery.AddField("urlParameterValue");
            return this;
        }

        public MarketingActivityQueryBuilder UtmParameters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UTMParametersQueryBuilder> build)
        {
            var query = new Query<UTMParameters>("utmParameters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UTMParametersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UTMParameters>(query);
            return this;
        }
    }
}