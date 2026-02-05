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
    public sealed class MarketWebPresenceUpdateArgumentsBuilder : ArgumentsBuilderBase<MarketWebPresenceUpdatePayload, MarketWebPresenceUpdateArgumentsBuilder>
    {
        protected override MarketWebPresenceUpdateArgumentsBuilder Self => this;

        public MarketWebPresenceUpdateArgumentsBuilder(IQuery<MarketWebPresenceUpdatePayload> query) : base(query)
        {
        }

        public MarketWebPresenceUpdateArgumentsBuilder WebPresence(MarketWebPresenceUpdateInput? webPresence)
        {
            base.InnerQuery.AddArgument("webPresence", webPresence);
            return this;
        }

        public MarketWebPresenceUpdateArgumentsBuilder WebPresenceId(string? webPresenceId)
        {
            base.InnerQuery.AddArgument("webPresenceId", webPresenceId);
            return this;
        }
    }
}