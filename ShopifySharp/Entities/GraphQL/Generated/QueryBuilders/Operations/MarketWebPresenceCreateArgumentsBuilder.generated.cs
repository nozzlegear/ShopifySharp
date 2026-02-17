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