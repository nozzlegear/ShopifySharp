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
    public sealed class ChannelFullSyncArgumentsBuilder : ArgumentsBuilderBase<ChannelFullSyncPayload, ChannelFullSyncArgumentsBuilder>
    {
        protected override ChannelFullSyncArgumentsBuilder Self => this;

        public ChannelFullSyncArgumentsBuilder(IQuery<ChannelFullSyncPayload> query) : base(query)
        {
        }

        public ChannelFullSyncArgumentsBuilder BeforeUpdatedAt(DateTimeOffset? beforeUpdatedAt)
        {
            base.InnerQuery.AddArgument("beforeUpdatedAt", beforeUpdatedAt);
            return this;
        }

        public ChannelFullSyncArgumentsBuilder ChannelId(string? channelId)
        {
            base.InnerQuery.AddArgument("channelId", channelId);
            return this;
        }

        public ChannelFullSyncArgumentsBuilder Country(CountryCode? country)
        {
            base.InnerQuery.AddArgument("country", country);
            return this;
        }

        public ChannelFullSyncArgumentsBuilder Language(LanguageCode? language)
        {
            base.InnerQuery.AddArgument("language", language);
            return this;
        }

        public ChannelFullSyncArgumentsBuilder UpdatedAtSince(DateTimeOffset? updatedAtSince)
        {
            base.InnerQuery.AddArgument("updatedAtSince", updatedAtSince);
            return this;
        }
    }
}