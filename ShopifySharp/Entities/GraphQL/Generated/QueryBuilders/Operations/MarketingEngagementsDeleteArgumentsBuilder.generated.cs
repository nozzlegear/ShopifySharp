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