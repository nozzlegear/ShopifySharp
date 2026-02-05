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
    public sealed class MarketingActivityOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivity, MarketingActivityOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivity>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketingActivityArgumentsBuilder Arguments { get; }
        protected override MarketingActivityOperationQueryBuilder Self => this;

        public MarketingActivityOperationQueryBuilder() : this("marketingActivity")
        {
        }

        public MarketingActivityOperationQueryBuilder(string name) : base(new Query<MarketingActivity>(name))
        {
            Arguments = new MarketingActivityArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityOperationQueryBuilder(IQuery<MarketingActivity> query) : base(query)
        {
            Arguments = new MarketingActivityArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityOperationQueryBuilder ActivityListUrl()
        {
            base.InnerQuery.AddField("activityListUrl");
            return this;
        }

        public MarketingActivityOperationQueryBuilder AdSpend(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("adSpend");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MarketingActivityOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MarketingActivityOperationQueryBuilder AppErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityExtensionAppErrorsQueryBuilder> build)
        {
            var query = new Query<MarketingActivityExtensionAppErrors>("appErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityExtensionAppErrorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityExtensionAppErrors>(query);
            return this;
        }

        public MarketingActivityOperationQueryBuilder Budget(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingBudgetQueryBuilder> build)
        {
            var query = new Query<MarketingBudget>("budget");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingBudgetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingBudget>(query);
            return this;
        }

        public MarketingActivityOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MarketingActivityOperationQueryBuilder FormData()
        {
            base.InnerQuery.AddField("formData");
            return this;
        }

        public MarketingActivityOperationQueryBuilder HierarchyLevel()
        {
            base.InnerQuery.AddField("hierarchyLevel");
            return this;
        }

        public MarketingActivityOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketingActivityOperationQueryBuilder InMainWorkflowVersion()
        {
            base.InnerQuery.AddField("inMainWorkflowVersion");
            return this;
        }

        public MarketingActivityOperationQueryBuilder IsExternal()
        {
            base.InnerQuery.AddField("isExternal");
            return this;
        }

        [Obsolete("Use `marketingChannelType` instead.")]
        public MarketingActivityOperationQueryBuilder MarketingChannel()
        {
            base.InnerQuery.AddField("marketingChannel");
            return this;
        }

        public MarketingActivityOperationQueryBuilder MarketingChannelType()
        {
            base.InnerQuery.AddField("marketingChannelType");
            return this;
        }

        public MarketingActivityOperationQueryBuilder MarketingEvent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("marketingEvent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public MarketingActivityOperationQueryBuilder ParentActivityId()
        {
            base.InnerQuery.AddField("parentActivityId");
            return this;
        }

        public MarketingActivityOperationQueryBuilder ParentRemoteId()
        {
            base.InnerQuery.AddField("parentRemoteId");
            return this;
        }

        public MarketingActivityOperationQueryBuilder SourceAndMedium()
        {
            base.InnerQuery.AddField("sourceAndMedium");
            return this;
        }

        public MarketingActivityOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `statusBadgeTypeV2` instead.")]
        public MarketingActivityOperationQueryBuilder StatusBadgeType()
        {
            base.InnerQuery.AddField("statusBadgeType");
            return this;
        }

        public MarketingActivityOperationQueryBuilder StatusBadgeTypeV2()
        {
            base.InnerQuery.AddField("statusBadgeTypeV2");
            return this;
        }

        public MarketingActivityOperationQueryBuilder StatusLabel()
        {
            base.InnerQuery.AddField("statusLabel");
            return this;
        }

        public MarketingActivityOperationQueryBuilder StatusTransitionedAt()
        {
            base.InnerQuery.AddField("statusTransitionedAt");
            return this;
        }

        public MarketingActivityOperationQueryBuilder Tactic()
        {
            base.InnerQuery.AddField("tactic");
            return this;
        }

        public MarketingActivityOperationQueryBuilder TargetStatus()
        {
            base.InnerQuery.AddField("targetStatus");
            return this;
        }

        public MarketingActivityOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public MarketingActivityOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MarketingActivityOperationQueryBuilder UrlParameterValue()
        {
            base.InnerQuery.AddField("urlParameterValue");
            return this;
        }

        public MarketingActivityOperationQueryBuilder UtmParameters(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UTMParametersQueryBuilder> build)
        {
            var query = new Query<UTMParameters>("utmParameters");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UTMParametersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UTMParameters>(query);
            return this;
        }
    }
}