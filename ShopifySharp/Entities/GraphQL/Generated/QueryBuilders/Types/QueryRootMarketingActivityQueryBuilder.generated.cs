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
    public sealed class QueryRootMarketingActivityQueryBuilder : FieldsQueryBuilderBase<MarketingActivity, QueryRootMarketingActivityQueryBuilder>, IHasArguments<QueryRootMarketingActivityArgumentsBuilder>
    {
        public QueryRootMarketingActivityArgumentsBuilder Arguments { get; }
        protected override QueryRootMarketingActivityQueryBuilder Self => this;

        public QueryRootMarketingActivityQueryBuilder(string name) : base(new Query<MarketingActivity>(name))
        {
            Arguments = new QueryRootMarketingActivityArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketingActivityQueryBuilder(IQuery<MarketingActivity> query) : base(query)
        {
            Arguments = new QueryRootMarketingActivityArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketingActivityQueryBuilder SetArguments(Action<QueryRootMarketingActivityArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder ActivityListUrl()
        {
            base.InnerQuery.AddField("activityListUrl");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder AdSpend(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("adSpend");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder AppErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityExtensionAppErrorsQueryBuilder> build)
        {
            var query = new Query<MarketingActivityExtensionAppErrors>("appErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityExtensionAppErrorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityExtensionAppErrors>(query);
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder Budget(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingBudgetQueryBuilder> build)
        {
            var query = new Query<MarketingBudget>("budget");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingBudgetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingBudget>(query);
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder FormData()
        {
            base.InnerQuery.AddField("formData");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder HierarchyLevel()
        {
            base.InnerQuery.AddField("hierarchyLevel");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder InMainWorkflowVersion()
        {
            base.InnerQuery.AddField("inMainWorkflowVersion");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder IsExternal()
        {
            base.InnerQuery.AddField("isExternal");
            return this;
        }

        [Obsolete("Use `marketingChannelType` instead.")]
        public QueryRootMarketingActivityQueryBuilder MarketingChannel()
        {
            base.InnerQuery.AddField("marketingChannel");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder MarketingChannelType()
        {
            base.InnerQuery.AddField("marketingChannelType");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder MarketingEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("marketingEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder ParentActivityId()
        {
            base.InnerQuery.AddField("parentActivityId");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder ParentRemoteId()
        {
            base.InnerQuery.AddField("parentRemoteId");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder SourceAndMedium()
        {
            base.InnerQuery.AddField("sourceAndMedium");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `statusBadgeTypeV2` instead.")]
        public QueryRootMarketingActivityQueryBuilder StatusBadgeType()
        {
            base.InnerQuery.AddField("statusBadgeType");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder StatusBadgeTypeV2()
        {
            base.InnerQuery.AddField("statusBadgeTypeV2");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder StatusLabel()
        {
            base.InnerQuery.AddField("statusLabel");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder StatusTransitionedAt()
        {
            base.InnerQuery.AddField("statusTransitionedAt");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder Tactic()
        {
            base.InnerQuery.AddField("tactic");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder TargetStatus()
        {
            base.InnerQuery.AddField("targetStatus");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder UrlParameterValue()
        {
            base.InnerQuery.AddField("urlParameterValue");
            return this;
        }

        public QueryRootMarketingActivityQueryBuilder UtmParameters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UTMParametersQueryBuilder> build)
        {
            var query = new Query<UTMParameters>("utmParameters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UTMParametersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UTMParameters>(query);
            return this;
        }
    }
}