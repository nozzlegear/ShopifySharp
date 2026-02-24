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
    public sealed class QueryRootMarketingEventQueryBuilder : FieldsQueryBuilderBase<MarketingEvent, QueryRootMarketingEventQueryBuilder>, IHasArguments<QueryRootMarketingEventArgumentsBuilder>
    {
        public QueryRootMarketingEventArgumentsBuilder Arguments { get; }
        protected override QueryRootMarketingEventQueryBuilder Self => this;

        public QueryRootMarketingEventQueryBuilder(string name) : base(new Query<MarketingEvent>(name))
        {
            Arguments = new QueryRootMarketingEventArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketingEventQueryBuilder(IQuery<MarketingEvent> query) : base(query)
        {
            Arguments = new QueryRootMarketingEventArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketingEventQueryBuilder SetArguments(Action<QueryRootMarketingEventArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMarketingEventQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        [Obsolete("Use `marketingChannelType` instead.")]
        public QueryRootMarketingEventQueryBuilder Channel()
        {
            base.InnerQuery.AddField("channel");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder ChannelHandle()
        {
            base.InnerQuery.AddField("channelHandle");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder EndedAt()
        {
            base.InnerQuery.AddField("endedAt");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder ManageUrl()
        {
            base.InnerQuery.AddField("manageUrl");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder MarketingChannelType()
        {
            base.InnerQuery.AddField("marketingChannelType");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder PreviewUrl()
        {
            base.InnerQuery.AddField("previewUrl");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder RemoteId()
        {
            base.InnerQuery.AddField("remoteId");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder ScheduledToEndAt()
        {
            base.InnerQuery.AddField("scheduledToEndAt");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder SourceAndMedium()
        {
            base.InnerQuery.AddField("sourceAndMedium");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder StartedAt()
        {
            base.InnerQuery.AddField("startedAt");
            return this;
        }

        [Obsolete("Use `sourceAndMedium` instead.")]
        public QueryRootMarketingEventQueryBuilder TargetTypeDisplayText()
        {
            base.InnerQuery.AddField("targetTypeDisplayText");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder UtmCampaign()
        {
            base.InnerQuery.AddField("utmCampaign");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder UtmMedium()
        {
            base.InnerQuery.AddField("utmMedium");
            return this;
        }

        public QueryRootMarketingEventQueryBuilder UtmSource()
        {
            base.InnerQuery.AddField("utmSource");
            return this;
        }
    }
}