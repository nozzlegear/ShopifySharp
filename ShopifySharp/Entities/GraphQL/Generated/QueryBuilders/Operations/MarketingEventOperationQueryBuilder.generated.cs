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
    public sealed class MarketingEventOperationQueryBuilder : FieldsQueryBuilderBase<MarketingEvent, MarketingEventOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingEvent>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketingEventArgumentsBuilder Arguments { get; }
        protected override MarketingEventOperationQueryBuilder Self => this;

        public MarketingEventOperationQueryBuilder() : this("marketingEvent")
        {
        }

        public MarketingEventOperationQueryBuilder(string name) : base(new Query<MarketingEvent>(name))
        {
            Arguments = new MarketingEventArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEventOperationQueryBuilder(IQuery<MarketingEvent> query) : base(query)
        {
            Arguments = new MarketingEventArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEventOperationQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        [Obsolete("Use `marketingChannelType` instead.")]
        public MarketingEventOperationQueryBuilder Channel()
        {
            base.InnerQuery.AddField("channel");
            return this;
        }

        public MarketingEventOperationQueryBuilder ChannelHandle()
        {
            base.InnerQuery.AddField("channelHandle");
            return this;
        }

        public MarketingEventOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MarketingEventOperationQueryBuilder EndedAt()
        {
            base.InnerQuery.AddField("endedAt");
            return this;
        }

        public MarketingEventOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketingEventOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public MarketingEventOperationQueryBuilder ManageUrl()
        {
            base.InnerQuery.AddField("manageUrl");
            return this;
        }

        public MarketingEventOperationQueryBuilder MarketingChannelType()
        {
            base.InnerQuery.AddField("marketingChannelType");
            return this;
        }

        public MarketingEventOperationQueryBuilder PreviewUrl()
        {
            base.InnerQuery.AddField("previewUrl");
            return this;
        }

        public MarketingEventOperationQueryBuilder RemoteId()
        {
            base.InnerQuery.AddField("remoteId");
            return this;
        }

        public MarketingEventOperationQueryBuilder ScheduledToEndAt()
        {
            base.InnerQuery.AddField("scheduledToEndAt");
            return this;
        }

        public MarketingEventOperationQueryBuilder SourceAndMedium()
        {
            base.InnerQuery.AddField("sourceAndMedium");
            return this;
        }

        public MarketingEventOperationQueryBuilder StartedAt()
        {
            base.InnerQuery.AddField("startedAt");
            return this;
        }

        [Obsolete("Use `sourceAndMedium` instead.")]
        public MarketingEventOperationQueryBuilder TargetTypeDisplayText()
        {
            base.InnerQuery.AddField("targetTypeDisplayText");
            return this;
        }

        public MarketingEventOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MarketingEventOperationQueryBuilder UtmCampaign()
        {
            base.InnerQuery.AddField("utmCampaign");
            return this;
        }

        public MarketingEventOperationQueryBuilder UtmMedium()
        {
            base.InnerQuery.AddField("utmMedium");
            return this;
        }

        public MarketingEventOperationQueryBuilder UtmSource()
        {
            base.InnerQuery.AddField("utmSource");
            return this;
        }
    }
}