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
    public sealed class MarketingEventQueryBuilder : FieldsQueryBuilderBase<MarketingEvent, MarketingEventQueryBuilder>
    {
        protected override MarketingEventQueryBuilder Self => this;

        public MarketingEventQueryBuilder() : this("marketingEvent")
        {
        }

        public MarketingEventQueryBuilder(string name) : base(new Query<MarketingEvent>(name))
        {
        }

        public MarketingEventQueryBuilder(IQuery<MarketingEvent> query) : base(query)
        {
        }

        public MarketingEventQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        [Obsolete("Use `marketingChannelType` instead.")]
        public MarketingEventQueryBuilder Channel()
        {
            base.InnerQuery.AddField("channel");
            return this;
        }

        public MarketingEventQueryBuilder ChannelHandle()
        {
            base.InnerQuery.AddField("channelHandle");
            return this;
        }

        public MarketingEventQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MarketingEventQueryBuilder EndedAt()
        {
            base.InnerQuery.AddField("endedAt");
            return this;
        }

        public MarketingEventQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketingEventQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public MarketingEventQueryBuilder ManageUrl()
        {
            base.InnerQuery.AddField("manageUrl");
            return this;
        }

        public MarketingEventQueryBuilder MarketingChannelType()
        {
            base.InnerQuery.AddField("marketingChannelType");
            return this;
        }

        public MarketingEventQueryBuilder PreviewUrl()
        {
            base.InnerQuery.AddField("previewUrl");
            return this;
        }

        public MarketingEventQueryBuilder RemoteId()
        {
            base.InnerQuery.AddField("remoteId");
            return this;
        }

        public MarketingEventQueryBuilder ScheduledToEndAt()
        {
            base.InnerQuery.AddField("scheduledToEndAt");
            return this;
        }

        public MarketingEventQueryBuilder SourceAndMedium()
        {
            base.InnerQuery.AddField("sourceAndMedium");
            return this;
        }

        public MarketingEventQueryBuilder StartedAt()
        {
            base.InnerQuery.AddField("startedAt");
            return this;
        }

        [Obsolete("Use `sourceAndMedium` instead.")]
        public MarketingEventQueryBuilder TargetTypeDisplayText()
        {
            base.InnerQuery.AddField("targetTypeDisplayText");
            return this;
        }

        public MarketingEventQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MarketingEventQueryBuilder UtmCampaign()
        {
            base.InnerQuery.AddField("utmCampaign");
            return this;
        }

        public MarketingEventQueryBuilder UtmMedium()
        {
            base.InnerQuery.AddField("utmMedium");
            return this;
        }

        public MarketingEventQueryBuilder UtmSource()
        {
            base.InnerQuery.AddField("utmSource");
            return this;
        }
    }
}