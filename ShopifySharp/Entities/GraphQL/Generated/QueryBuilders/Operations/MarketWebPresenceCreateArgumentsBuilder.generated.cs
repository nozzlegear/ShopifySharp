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
    public sealed class MarketWebPresenceCreateArgumentsBuilder : ArgumentsBuilderBase<MarketWebPresenceCreatePayload, MarketWebPresenceCreateArgumentsBuilder>
    {
        protected override MarketWebPresenceCreateArgumentsBuilder Self => this;

        public MarketWebPresenceCreateArgumentsBuilder(IQuery<MarketWebPresenceCreatePayload> query) : base(query)
        {
        }

        public MarketWebPresenceCreateArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }

        public MarketWebPresenceCreateArgumentsBuilder WebPresence(MarketWebPresenceCreateInput? webPresence)
        {
            base.InnerQuery.AddArgument("webPresence", webPresence);
            return this;
        }
    }
}