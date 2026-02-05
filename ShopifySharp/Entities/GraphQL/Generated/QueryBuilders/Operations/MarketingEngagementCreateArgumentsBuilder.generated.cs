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
    public sealed class MarketingEngagementCreateArgumentsBuilder : ArgumentsBuilderBase<MarketingEngagementCreatePayload, MarketingEngagementCreateArgumentsBuilder>
    {
        protected override MarketingEngagementCreateArgumentsBuilder Self => this;

        public MarketingEngagementCreateArgumentsBuilder(IQuery<MarketingEngagementCreatePayload> query) : base(query)
        {
        }

        public MarketingEngagementCreateArgumentsBuilder ChannelHandle(string? channelHandle)
        {
            base.InnerQuery.AddArgument("channelHandle", channelHandle);
            return this;
        }

        public MarketingEngagementCreateArgumentsBuilder MarketingActivityId(string? marketingActivityId)
        {
            base.InnerQuery.AddArgument("marketingActivityId", marketingActivityId);
            return this;
        }

        public MarketingEngagementCreateArgumentsBuilder MarketingEngagement(MarketingEngagementInput? marketingEngagement)
        {
            base.InnerQuery.AddArgument("marketingEngagement", marketingEngagement);
            return this;
        }

        public MarketingEngagementCreateArgumentsBuilder RemoteId(string? remoteId)
        {
            base.InnerQuery.AddArgument("remoteId", remoteId);
            return this;
        }
    }
}