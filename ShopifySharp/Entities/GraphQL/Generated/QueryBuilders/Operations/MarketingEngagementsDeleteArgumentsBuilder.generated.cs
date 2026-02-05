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
    public sealed class MarketingEngagementsDeleteArgumentsBuilder : ArgumentsBuilderBase<MarketingEngagementsDeletePayload, MarketingEngagementsDeleteArgumentsBuilder>
    {
        protected override MarketingEngagementsDeleteArgumentsBuilder Self => this;

        public MarketingEngagementsDeleteArgumentsBuilder(IQuery<MarketingEngagementsDeletePayload> query) : base(query)
        {
        }

        public MarketingEngagementsDeleteArgumentsBuilder ChannelHandle(string? channelHandle)
        {
            base.InnerQuery.AddArgument("channelHandle", channelHandle);
            return this;
        }

        public MarketingEngagementsDeleteArgumentsBuilder DeleteEngagementsForAllChannels(bool? deleteEngagementsForAllChannels)
        {
            base.InnerQuery.AddArgument("deleteEngagementsForAllChannels", deleteEngagementsForAllChannels);
            return this;
        }
    }
}