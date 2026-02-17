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
    public sealed class MarketingEngagementQueryBuilder : FieldsQueryBuilderBase<MarketingEngagement, MarketingEngagementQueryBuilder>
    {
        protected override MarketingEngagementQueryBuilder Self => this;

        public MarketingEngagementQueryBuilder() : this("marketingEngagement")
        {
        }

        public MarketingEngagementQueryBuilder(string name) : base(new Query<MarketingEngagement>(name))
        {
        }

        public MarketingEngagementQueryBuilder(IQuery<MarketingEngagement> query) : base(query)
        {
        }

        public MarketingEngagementQueryBuilder AdSpend(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("adSpend");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MarketingEngagementQueryBuilder AllConversions()
        {
            base.InnerQuery.AddField("allConversions");
            return this;
        }

        public MarketingEngagementQueryBuilder ChannelHandle()
        {
            base.InnerQuery.AddField("channelHandle");
            return this;
        }

        public MarketingEngagementQueryBuilder ClicksCount()
        {
            base.InnerQuery.AddField("clicksCount");
            return this;
        }

        public MarketingEngagementQueryBuilder CommentsCount()
        {
            base.InnerQuery.AddField("commentsCount");
            return this;
        }

        public MarketingEngagementQueryBuilder ComplaintsCount()
        {
            base.InnerQuery.AddField("complaintsCount");
            return this;
        }

        public MarketingEngagementQueryBuilder FailsCount()
        {
            base.InnerQuery.AddField("failsCount");
            return this;
        }

        public MarketingEngagementQueryBuilder FavoritesCount()
        {
            base.InnerQuery.AddField("favoritesCount");
            return this;
        }

        public MarketingEngagementQueryBuilder FirstTimeCustomers()
        {
            base.InnerQuery.AddField("firstTimeCustomers");
            return this;
        }

        public MarketingEngagementQueryBuilder ImpressionsCount()
        {
            base.InnerQuery.AddField("impressionsCount");
            return this;
        }

        public MarketingEngagementQueryBuilder IsCumulative()
        {
            base.InnerQuery.AddField("isCumulative");
            return this;
        }

        public MarketingEngagementQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingEngagementQueryBuilder OccurredOn()
        {
            base.InnerQuery.AddField("occurredOn");
            return this;
        }

        public MarketingEngagementQueryBuilder Orders()
        {
            base.InnerQuery.AddField("orders");
            return this;
        }

        public MarketingEngagementQueryBuilder PrimaryConversions()
        {
            base.InnerQuery.AddField("primaryConversions");
            return this;
        }

        public MarketingEngagementQueryBuilder ReturningCustomers()
        {
            base.InnerQuery.AddField("returningCustomers");
            return this;
        }

        public MarketingEngagementQueryBuilder Sales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("sales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MarketingEngagementQueryBuilder SendsCount()
        {
            base.InnerQuery.AddField("sendsCount");
            return this;
        }

        public MarketingEngagementQueryBuilder SessionsCount()
        {
            base.InnerQuery.AddField("sessionsCount");
            return this;
        }

        public MarketingEngagementQueryBuilder SharesCount()
        {
            base.InnerQuery.AddField("sharesCount");
            return this;
        }

        public MarketingEngagementQueryBuilder UniqueClicksCount()
        {
            base.InnerQuery.AddField("uniqueClicksCount");
            return this;
        }

        public MarketingEngagementQueryBuilder UniqueViewsCount()
        {
            base.InnerQuery.AddField("uniqueViewsCount");
            return this;
        }

        public MarketingEngagementQueryBuilder UnsubscribesCount()
        {
            base.InnerQuery.AddField("unsubscribesCount");
            return this;
        }

        public MarketingEngagementQueryBuilder UtcOffset()
        {
            base.InnerQuery.AddField("utcOffset");
            return this;
        }

        public MarketingEngagementQueryBuilder ViewsCount()
        {
            base.InnerQuery.AddField("viewsCount");
            return this;
        }
    }
}